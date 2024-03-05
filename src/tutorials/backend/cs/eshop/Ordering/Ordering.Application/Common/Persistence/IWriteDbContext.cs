namespace Ordering.Application.Common.Persistence
{
    public interface IWriteDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
