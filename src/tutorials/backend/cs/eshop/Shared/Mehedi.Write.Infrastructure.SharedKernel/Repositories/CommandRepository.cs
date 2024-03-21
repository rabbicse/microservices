using Mehedi.Application.SharedKernel.Persistence;
using Mehedi.Core.SharedKernel;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Mehedi.Write.Infrastructure.SharedKernel.Repositories
{
    public abstract class CommandRepository<TEntity, TKey>(IWriteDbContext dbContext) : IDisposable, ICommandRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        private readonly IWriteDbContext _dbContext = dbContext;
        private DbSet<TEntity> _dbSet;

        protected DbSet<TEntity> DbSet => _dbSet ??= ((DbContext)_dbContext).Set<TEntity>();

        #region ICommandRepository<TEntity, TKey>   
        /// <summary>
        /// Add new entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var result = await DbSet.AddAsync(entity);
            if (result.State != EntityState.Added)
                throw new InvalidOperationException($"{nameof(entity)} didn't added!");

            return entity;
        }

        /// <summary>
        /// Add new entities in batch
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<IEnumerable<TEntity>> AddAsync(IEnumerable<TEntity> entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await DbSet.AddRangeAsync(entity);
            return entity;
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            DbSet.Update(entity);
            await Task.CompletedTask;
            return entity;
        }

        /// <summary>
        /// Update entities in batch
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<IEnumerable<TEntity>> UpdateAsync(IEnumerable<TEntity> entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            DbSet.UpdateRange(entity);
            await Task.CompletedTask;
            return entity;
        }
        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task DeleteAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            DbSet.Remove(entity);
            await Task.CompletedTask;
        }
        /// <summary>
        /// Delete entities in batch
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task DeleteAsync(IEnumerable<TEntity> entity)
        {
            if (entity != null)
            {
                DbSet.RemoveRange(entity);
                await Task.CompletedTask;
            }
            else
            {
                throw new ArgumentNullException(nameof(entity));
            }
        }
        /// <summary>
        /// Delete entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<TEntity> DeleteByIdAsync(TKey id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            var data = await DbSet.FindAsync(id);
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            DbSet.Remove(data);
            // TODO: need optimization later
            await Task.CompletedTask;
            return data;
        }
        /// <summary>
        /// Get entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _dbSet.AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(entity => entity.Id.Equals(id));
        }
        /// <summary>
        /// Get entities by expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<IReadOnlyList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region IDisposable
        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                // Free unmanaged resources
                (_dbContext as DbContext)?.Dispose();
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
