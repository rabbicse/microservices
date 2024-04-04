using KYC.EventStore.Infrastructure.Mappings;
using Mehedi.Application.SharedKernel.Services;
using Microsoft.EntityFrameworkCore;

namespace KYC.EventStore.Infrastructure.Persistence;

public class EventStoreDbContext(DbContextOptions<EventStoreDbContext> dbOptions) : BaseDbContext<EventStoreDbContext>(dbOptions)
{
    public DbSet<EventStoreEvent> EventStores => Set<EventStoreEvent>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new EventStoreConfiguration());
    }
}
