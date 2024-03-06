using MediatR;
using Microsoft.EntityFrameworkCore;
using Ordering.Application.Common.Persistence;
using Ordering.Domain.Common;

namespace Ordering.Write.Infrastructure.Common
{
    // TODO: Optimize
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IWriteDbContext _dbContext;
        private readonly IMediator _mediator;// = mediator;
        // TODO: IEventStore, IProducer, IDomainEvent
        public UnitOfWork(IWriteDbContext dbContext, IMediator mediator)
        {
            _dbContext = dbContext;
            _mediator = mediator;
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
            // TODO: 
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            using (var transaction = await (_dbContext as DbContext).Database.BeginTransactionAsync(cancellationToken))
            {
                try
                {
                    var affectedRows = await _dbContext.SaveChangesAsync(cancellationToken);
                    await transaction.CommitAsync(cancellationToken);
                    return await Task.FromResult(true);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    //throw ex.InnerException;
                    return await Task.FromResult(false);
                }
            }
        }

        ///// <summary>
        ///// Saves changes asynchronously.
        ///// </summary>
        //public async Task SaveChangesAsync()
        //{
        //    // Creating the execution strategy (Connection resiliency and database retries).
        //    var strategy = _dbContext.Database.CreateExecutionStrategy();

        //    // Executing the strategy.
        //    await strategy.ExecuteAsync(async () =>
        //    {
        //        await using var transaction = await _writeDbContext.Database.BeginTransactionAsync(IsolationLevel.ReadCommitted);

        //        _logger.LogInformation("----- Begin transaction: '{TransactionId}'", transaction.TransactionId);

        //        try
        //        {
        //            // Getting the domain events and event stores from the tracked entities in the EF Core context.
        //            var (domainEvents, eventStores) = BeforeSaveChanges();

        //            var rowsAffected = await _writeDbContext.SaveChangesAsync();

        //            _logger.LogInformation("----- Commit transaction: '{TransactionId}'", transaction.TransactionId);

        //            await transaction.CommitAsync();

        //            // Triggering the events and saving the stores.
        //            await AfterSaveChangesAsync(domainEvents, eventStores);

        //            _logger.LogInformation(
        //                "----- Transaction successfully confirmed: '{TransactionId}', Rows Affected: {RowsAffected}",
        //                transaction.TransactionId,
        //                rowsAffected);
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(
        //                ex,
        //                "An unexpected exception occurred while committing the transaction: '{TransactionId}', message: {Message}",
        //                transaction.TransactionId,
        //                ex.Message);

        //            await transaction.RollbackAsync();

        //            throw;
        //        }
        //    });
        //}

        ///// <summary>
        ///// Executes logic before saving changes to the database.
        ///// </summary>
        ///// <returns>A tuple containing the list of domain events and event stores.</returns>
        //private (IReadOnlyList<BaseEvent> domainEvents, IReadOnlyList<EventStore> eventStores) BeforeSaveChanges()
        //{
        //    // Get all domain entities with pending domain events
        //    var domainEntities = _writeDbContext
        //        .ChangeTracker
        //        .Entries<BaseEntity>()
        //        .Where(entry => entry.Entity.DomainEvents.Any())
        //        .ToList();

        //    // Get all domain events from the domain entities
        //    var domainEvents = domainEntities
        //        .SelectMany(entry => entry.Entity.DomainEvents)
        //        .ToList();

        //    // Convert domain events to event stores
        //    var eventStores = domainEvents
        //        .ConvertAll(@event => new EventStore(@event.AggregateId, @event.GetGenericTypeName(), @event.ToJson()));

        //    // Clear domain events from the entities
        //    domainEntities.ForEach(entry => entry.Entity.ClearDomainEvents());

        //    return (domainEvents.AsReadOnly(), eventStores.AsReadOnly());
        //}

        ///// <summary>
        ///// Performs necessary actions after saving changes, such as publishing domain events and storing event stores.
        ///// </summary>
        ///// <param name="domainEvents">The list of domain events.</param>
        ///// <param name="eventStores">The list of event stores.</param>
        ///// <returns>A task representing the asynchronous operation.</returns>
        //private async Task AfterSaveChangesAsync(
        //    IReadOnlyList<BaseEvent> domainEvents,
        //    IReadOnlyList<EventStore> eventStores)
        //{
        //    // If there are no domain events or event stores, return without performing any actions.
        //    if (!domainEvents.Any() || !eventStores.Any())
        //        return;

        //    // Publish each domain event in parallel using _mediator.
        //    var tasks = domainEvents
        //        .AsParallel()
        //        .Select(@event => _mediator.Publish(@event))
        //        .ToList();

        //    // Wait for all the published events to be processed.
        //    await Task.WhenAll(tasks);

        //    // Store the event stores using _eventStoreRepository.
        //    await _eventStoreRepository.StoreAsync(eventStores);
        //}


        #region IDisposable
        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                // Free unmanaged resources
            }

            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
        #endregion
    }

}
