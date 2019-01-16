using Identity.Service.Application.Identity.Store;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Identity.Repository
{
    public class ApplicationUserRepository : IRepository<ApplicationUser, string>
    {
        private IDocumentStore _context;
        private Lazy<IAsyncDocumentSession> _session;

        public ApplicationUserRepository(IIdentityDocumentStoreHolder context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            this._context = context.Store;

            this._session = new Lazy<IAsyncDocumentSession>(() =>
            {
                var session = _context.OpenAsyncSession();
                session.Advanced.UseOptimisticConcurrency = true;
                return session;
            }, true);
        }


        public IAsyncDocumentSession Session => _session.Value;

        public async Task<ApplicationUser> AddAsync(ApplicationUser entity, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            ThrowIfDisposed();

            if (entity == null) { throw new ArgumentNullException(nameof(entity)); }

            cancellationToken.ThrowIfCancellationRequested();

            await Session.StoreAsync(entity, cancellationToken);
            await SaveChanges(cancellationToken);

            return entity;
        }

        public async Task<IList<ApplicationUser>> AllAsync(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            cancellationToken.ThrowIfCancellationRequested();

            return await Session.Query<ApplicationUser>().ToListAsync();
        }

        #region IDisposable
        private void ThrowIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        private bool _disposed;
        public void Dispose()
        {
            Session.Dispose();
            _disposed = true;
        }
        #endregion

        public Task<ApplicationUser> FindByKeyAsync(string key, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            cancellationToken.ThrowIfCancellationRequested();
            return Session.LoadAsync<ApplicationUser>(key, cancellationToken);
        }

        public async Task<IList<ApplicationUser>> QueryAsync(Expression<Func<ApplicationUser, bool>> expression, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            return await Session.Query<ApplicationUser>().Where(expression).ToListAsync(cancellationToken);
        }

        public async Task<ApplicationUser> RemoveAsync(ApplicationUser entity, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            Session.Delete(entity.Id);

            await SaveChanges(cancellationToken);

            return entity;
        }

        public Task SaveChanges(CancellationToken cancellationToken = default(CancellationToken)) => Session.SaveChangesAsync(cancellationToken);

        public async Task<ApplicationUser> UpdateAsync(ApplicationUser entity, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var stored = await Session.LoadAsync<ApplicationUser>(entity.Id, cancellationToken);
            var etag = Session.Advanced.GetChangeVectorFor(stored);

            await Session.StoreAsync(entity, etag, cancellationToken);

            await SaveChanges(cancellationToken);

            return entity;
        }
    }
}
