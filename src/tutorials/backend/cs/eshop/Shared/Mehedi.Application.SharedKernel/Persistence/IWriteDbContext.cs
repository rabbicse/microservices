namespace Mehedi.Application.SharedKernel.Persistence
{
    public interface IWriteDbContext : IDisposable
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
