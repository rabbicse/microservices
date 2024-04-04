using Mehedi.Application.SharedKernel.Persistence;
using Mehedi.Core.SharedKernel;

namespace Mehedi.Read.Infrastructure.SharedKernel.Repositories;

/// <summary>
/// Base repository class for read-only operations.
/// </summary>
/// <typeparam name="TQueryModel">The type of the query model.</typeparam>
/// <typeparam name="Tkey">The type of the key.</typeparam>
/// <remarks>
/// Initializes a new instance of the <see cref="BaseReadOnlyRepository{TQueryModel, Tkey}"/> class.
/// </remarks>
/// <param name="context">The read database context.</param>
public abstract class QueryRepository<TQueryModel, Tkey>(IReadDbContext context) : IQueryRepository<TQueryModel, Tkey>
    where TQueryModel : IQueryModel<Tkey>
    where Tkey : IEquatable<Tkey>
{
    protected readonly Task<IEnumerable<TQueryModel>> Collection = context.GetCollectionAsync<TQueryModel>();

    /// <summary>
    /// Gets a query model by its id.
    /// </summary>
    /// <param name="id">The id of the query model.</param>
    /// <returns>The query model.</returns>
    public async Task<TQueryModel?> GetByIdAsync(Tkey id)
    {
        var collections = await Collection;
        return collections.Where(queryModel => queryModel.Id.Equals(id)).FirstOrDefault();
    }
}
