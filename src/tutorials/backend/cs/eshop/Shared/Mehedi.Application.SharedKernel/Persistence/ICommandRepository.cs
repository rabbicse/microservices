using System.Linq.Expressions;

namespace Mehedi.Application.SharedKernel.Persistence;

public interface ICommandRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Insert data using EF
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<TEntity> InsertAsync(TEntity entity);
    /// <summary>
    /// Insert multiple data using EF
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<IEnumerable<TEntity>> InsertAsync(IEnumerable<TEntity> entity);
    /// <summary>
    /// Update data using EF
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<TEntity> UpdateAsync(TEntity entity);
    /// <summary>
    /// Update Multiple data using EF
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entity);
    /// <summary>
    /// Delete data using EF
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task DeleteAsync(TEntity entity);
    /// <summary>
    /// Delete multiple data using EF
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task DeleteAsync(IEnumerable<TEntity> entity);
    /// <summary>
    /// Delete By Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<TEntity> DeleteAsync(object id);
    /// <summary>
    /// Get by Id, It might be guid, long or anything
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<TEntity> GetAsync(object id);
    /// <summary>
    /// Get by expression
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
}
