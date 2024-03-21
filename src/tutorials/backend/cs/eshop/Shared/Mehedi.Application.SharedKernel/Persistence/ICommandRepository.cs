using Mehedi.Core.SharedKernel;
using System.Linq.Expressions;

namespace Mehedi.Application.SharedKernel.Persistence;

/// <summary>
/// Represents a repository that allows write-only operations on entities.
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TKey"></typeparam>
public interface ICommandRepository<TEntity, in TKey>: IDisposable where TEntity : IEntity<TKey> where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Insert data using EF
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<TEntity> AddAsync(TEntity entity);
    /// <summary>
    /// Insert multiple data using EF
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task<IEnumerable<TEntity>> AddAsync(IEnumerable<TEntity> entity);
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
    Task<TEntity> DeleteByIdAsync(TKey id);
    /// <summary>
    /// Get by Id, It might be guid, long or anything
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<TEntity> GetByIdAsync(TKey id);
    /// <summary>
    /// Get by expression
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
}
