using KYC.EventStore.Infrastructure.Persistence;
using Mehedi.Application.SharedKernel.Services;

namespace KYC.EventStore.Infrastructure.Repositories;

public sealed class EventStoreRepository(EventStoreDbContext context) : IEventStoreRepository
{
    private readonly EventStoreDbContext _context = context;

    public async Task StoreAsync(IEnumerable<EventStoreEvent> eventStores)
    {
        await _context.EventStores.AddRangeAsync(eventStores);
        await _context.SaveChangesAsync();
    }

    #region IDisposable

    // To detect redundant calls.
    private bool _disposed;

    // Public implementation of Dispose pattern callable by consumers.
    ~EventStoreRepository() => Dispose(false);

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
            _context.Dispose();

        _disposed = true;
    }

    #endregion
}
