using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application
{
    public interface IRepository<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        Task<IList<TEntity>> AllAsync(CancellationToken cancellationToken);
        Task<IList<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken);
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken);
        Task<TEntity> FindByKeyAsync(TKey key, CancellationToken cancellationToken);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken);
        Task<TEntity> RemoveAsync(TEntity entity, CancellationToken cancellationToken);
    }
}
