using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Raven.Client.Documents;
using Raven.Client.ServerWide.Operations;
using Raven.Client.ServerWide;
using System.Collections.Generic;
using System.Security.Claims;
using System;
using Raven.Client.Documents.Operations;
using Raven.Client.Exceptions.Database;
using Raven.Client.Exceptions;

namespace Identity.Service.Application.Identity.Store
{
    public class IdentityDocumentStoreHolder : IIdentityDocumentStoreHolder
    {
        private ILogger<IdentityDocumentStoreHolder> _logger;
        private IOptions<RavenSettings> _options;
        public IDocumentStore Store { get;}

        public IdentityDocumentStoreHolder(IOptions<RavenSettings> options, IDocumentStore store, ILogger<IdentityDocumentStoreHolder> logger)
        {
            this._logger = logger;
            this._options = options;
            var settings = options.Value;
            this.Store = store;

            Store.Initialize();

            this._logger.LogInformation($"Initialized RavenDB document store for {settings.Database} at {settings.Url}");

            EnsureDatabaseExists(this.Store, this.Store.Database);
            
        }
        #region Nothing to see here!

        public void EnsureDatabaseExists(IDocumentStore store, string database = null, bool createDatabaseIfNotExists = true)
        {
            database = database ?? store.Database;

            if (string.IsNullOrWhiteSpace(database))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(database));

            try
            {
                store.Maintenance.ForDatabase(database).Send(new GetStatisticsOperation());
            }
            catch (DatabaseDoesNotExistException)
            {
                this._logger.LogInformation("RavenDB database does not exist");
                if (createDatabaseIfNotExists == false) {
                    this._logger.LogInformation("Database creation disabled");
                    throw;
                }

                try
                {
                    this._logger.LogInformation("Creating and seeding with initial data.");
                    var createResult = Store.Maintenance.Server.Send(new CreateDatabaseOperation(new DatabaseRecord(database)));

                    if (createResult.Name != null)
                    {
                        var defaultRoles = new List<ApplicationRole>()
                    {
                        new ApplicationRole{
                            Id = null,
                            Name = "Admin",
                            NormalizedName = "ADMIN",
                            Claims = new List<Claim>() { new Claim(ClaimTypes.Role, "Admin") }
                        },
                        new ApplicationRole{
                            Id = null,
                            Name = "Guest",
                            NormalizedName = "GUEST",
                            Claims = new List<Claim>() { new Claim(ClaimTypes.Role, "Guest") }
                        }
                    };
                        using (var session = Store.OpenSession())
                        {
                            foreach (var role in defaultRoles)
                            {
                                session.Store(role);
                            }
                            session.SaveChanges();
                        }
                    }

                }
                catch (ConcurrencyException)
                {
                    // The database was already created before calling CreateDatabaseOperation
                }

            }
        }

        private void CreateDatabaseIfNotExists()
        {
            
            var database = Store.Database;
            var dbRecord = Store.Maintenance.Server.Send(new GetDatabaseRecordOperation(database));

            if (dbRecord == null)
            {
                this._logger.LogInformation("RavenDB database does not exist, creating and seeding with initial data");
                var createResult = Store.Maintenance.Server.Send(new CreateDatabaseOperation(new DatabaseRecord(database)));
                if (createResult.Name != null) {
                    var defaultRoles = new List<ApplicationRole>()
                    {
                        new ApplicationRole{
                            Id = null,
                            Name = "Admin",
                            NormalizedName = "ADMIN",
                            Claims = new List<Claim>() { new Claim(ClaimTypes.Role, "Admin") }
                        },
                        new ApplicationRole{
                            Id = null,
                            Name = "Guest",
                            NormalizedName = "GUEST",
                            Claims = new List<Claim>() { new Claim(ClaimTypes.Role, "Administrator") }
                        }
                    };
                    using (var session = Store.OpenSession())
                    {
                        foreach (var role in defaultRoles)
                        {
                            session.Store(role);
                        }
                        session.SaveChanges();
                    }
                }
            }
        }
        #endregion

    }
}
