using MediatR;
using Mehedi.Application.SharedKernel.Extensions;
using Mehedi.Application.SharedKernel.Persistence;
using Mehedi.Application.SharedKernel.Services;
using Mehedi.Core.SharedKernel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;

namespace Mehedi.Write.Infrastructure.SharedKernel.Persistence;

public class UnitOfWork(
    IWriteDbContext writeDbContext,
    IEventStoreRepository eventStoreRepository,
    IMediator mediator,
    ILogger<UnitOfWork> logger) : IUnitOfWork
{
    private readonly IEventStoreRepository _eventStoreRepository = eventStoreRepository;
    private readonly ILogger<UnitOfWork> _logger = logger;
    private readonly IMediator _mediator = mediator;
    private readonly IWriteDbContext _writeDbContext = writeDbContext;

    #region IUnitOfWork
    /// <summary>
    /// SaveChangesAsync: will trigger all domain events and integrated events
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var dbContext = (_writeDbContext as DbContext);
        // Creating the execution strategy (Connection resiliency and database retries).
        var strategy = dbContext?.Database.CreateExecutionStrategy();

        // Executing the strategy.
        return await strategy.ExecuteAsync(async () =>
        {
            await using var transaction = await dbContext.Database.BeginTransactionAsync(IsolationLevel.ReadCommitted, cancellationToken);
            _logger.LogInformation($"Begin transaction: '{transaction.TransactionId}'");

            try
            {
                // Getting the domain events and event stores from the tracked entities in the EF Core context.
                var (domainEvents, eventStores) = BeforeSaveChanges();

                var rowsAffected = await dbContext.SaveChangesAsync(cancellationToken);

                _logger.LogInformation($"Commit transaction: '{transaction.TransactionId}'");

                await transaction.CommitAsync();

                // Triggering the events and saving the stores.
                await AfterSaveChangesAsync(domainEvents, eventStores);

                _logger.LogInformation($"Transaction successfully confirmed: '{transaction.TransactionId}', Rows Affected: {rowsAffected}");
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An unexpected exception occurred while committing the transaction: '{transaction.TransactionId}', message: {ex.Message}");

                await transaction.RollbackAsync();

                throw;
            }
        });
    }
    #endregion

    #region Private-Method(s)
    /// <summary>
    /// Executes logic before saving changes to the database.
    /// </summary>
    /// <returns>A tuple containing the list of domain events and event stores.</returns>
    private (IReadOnlyList<BaseDomainEvent> domainEvents, IReadOnlyList<EventStore> eventStores) BeforeSaveChanges()
    {
        var dbContext = (_writeDbContext as DbContext);
        // Get all domain entities with pending domain events
        var domainEntities = dbContext
            .ChangeTracker
            .Entries<BaseEntity>()
            .Where(entry => entry.Entity.DomainEvents.Any())
            .ToList();

        // Get all domain events from the domain entities
        var domainEvents = domainEntities
            .SelectMany(entry => entry.Entity.DomainEvents)
            .ToList();

        // Convert domain events to event stores
        var eventStores = domainEvents
            .ConvertAll(@event => new EventStore(@event.AggregateId, @event.GetGenericTypeName(), @event.ToJson()));

        // Clear domain events from the entities
        domainEntities.ForEach(entry => entry.Entity.ClearDomainEvents());

        return (domainEvents.AsReadOnly(), eventStores.AsReadOnly());
    }

    /// <summary>
    /// Performs necessary actions after saving changes, such as publishing domain events and storing event stores.
    /// </summary>
    /// <param name="domainEvents">The list of domain events.</param>
    /// <param name="eventStores">The list of event stores.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    private async Task AfterSaveChangesAsync(
        IReadOnlyList<BaseDomainEvent> domainEvents,
        IReadOnlyList<EventStore> eventStores)
    {
        // If there are no domain events or event stores, return without performing any actions.
        if (!domainEvents.Any() || !eventStores.Any())
            return;

        // Publish each domain event in parallel using _mediator.
        var tasks = domainEvents
            .AsParallel()
            .Select(@event => _mediator.Publish(@event))
            .ToList();

        // Wait for all the published events to be processed.
        await Task.WhenAll(tasks);

        // Store the event stores using _eventStoreRepository.
        await _eventStoreRepository.StoreAsync(eventStores);
    }
    #endregion

    #region IDisposable

    // To detect redundant calls.
    private bool _disposed;

    // Public implementation of Dispose pattern callable by consumers.
    ~UnitOfWork() => Dispose(false);

    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Protected implementation of Dispose pattern.
    private void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        // Dispose managed state (managed objects).
        if (disposing)
        {
            _writeDbContext.Dispose();
            _eventStoreRepository.Dispose();
        }

        _disposed = true;
    }
    #endregion
}
