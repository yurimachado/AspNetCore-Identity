//using Microsoft.AspNetCore.Identity;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Identity.Service.Application
//{
//    public class InMemoryRoleStore : IRoleStore<IdentityRole>
//    {
//        private IRepository<IdentityRole, string> _repository;

//        public InMemoryRoleStore(IRepository<IdentityRole,string> repository)
//        {
//            this._repository = repository;
//        }

//        private IdentityResult RoleExists(IdentityRole role)
//        {
//            var roleFound = this._repository.FindByKey(role.Id);
//            if (roleFound == null)
//            {
//                return IdentityResult.Failed(new IdentityError[] {
//                    new IdentityError { Code = "0x80131577", Description = "Key Not Found." }
//                });
//            }
//            return IdentityResult.Success;
//        }

//        public Task<IdentityResult> CreateAsync(IdentityRole role, CancellationToken cancellationToken)
//        {
//            var roleFound = this._repository.Query(r => r.Name == role.Name).FirstOrDefault();
//            if (roleFound != null)
//            {
//                return Task.FromResult(IdentityResult.Failed(new IdentityError[] {
//                    new IdentityError { Code = "11000", Description = "Duplicate role. This role name must be Unique." }
//                }));
//            }

//            this._repository.Add(role);

//            return Task.FromResult(IdentityResult.Success);
//        }

//        public Task<IdentityResult> DeleteAsync(IdentityRole role, CancellationToken cancellationToken)
//        {
//            var roleToBeUpdated = this._repository.FindByKey(role.Id);

//            if (roleToBeUpdated == null)
//                return Task.FromResult(IdentityResult.Failed(new IdentityError[] {
//                    new IdentityError { Code = "0x80131577", Description = "Key Not Found." }
//                }));

//            this._repository.Remove(role);

//            return Task.FromResult(IdentityResult.Success);
//        }

//        public void Dispose()
//        {
//            //this.Dispose();
//        }

//        public Task<IdentityRole> FindByIdAsync(string roleId, CancellationToken cancellationToken)
//        {
//            return Task.FromResult(this._repository.FindByKey(roleId));
//        }

//        public Task<IdentityRole> FindByNameAsync(string normalizedName, CancellationToken cancellationToken)
//        {
//            return Task.FromResult(this._repository.Query(u => u.NormalizedName == normalizedName).FirstOrDefault());
//        }

//        public Task<string> GetNormalizedRoleNameAsync(IdentityRole role, CancellationToken cancellationToken)
//        {
//            var info = this._repository.FindByKey(role.Id);
//            if (info == null)
//                return Task.FromResult(string.Empty);

//            return Task.FromResult(info.NormalizedName);
//        }

//        public Task<string> GetRoleIdAsync(IdentityRole role, CancellationToken cancellationToken)
//        {
//            var info = this._repository.Query(u => u.Name == role.Name).FirstOrDefault();
//            if (info == null)
//                return Task.FromResult(string.Empty);

//            return Task.FromResult(info.Id);
//        }

//        public Task<string> GetRoleNameAsync(IdentityRole role, CancellationToken cancellationToken)
//        {
//            var info = this._repository.FindByKey(role.Id);
//            if (info == null)
//                return Task.FromResult(string.Empty);

//            return Task.FromResult(info.Name);
//        }

//        public Task SetNormalizedRoleNameAsync(IdentityRole role, string normalizedName, CancellationToken cancellationToken)
//        {
//            var info = this._repository.FindByKey(role.Id);
//            if (info == null)
//                return Task.CompletedTask;

//            info.NormalizedName = normalizedName;

//            return Task.CompletedTask;
//        }

//        public Task SetRoleNameAsync(IdentityRole role, string roleName, CancellationToken cancellationToken)
//        {
//            var info = this._repository.FindByKey(role.Id);
//            if (info == null)
//                return Task.CompletedTask;

//            info.Name = roleName;

//            return Task.CompletedTask;
//        }

//        public Task<IdentityResult> UpdateAsync(IdentityRole role, CancellationToken cancellationToken)
//        {
//            var result = RoleExists(role);

//            if (!result.Succeeded)
//                return Task.FromResult(result);

//            this._repository.Update(role);

//            return Task.FromResult(result);
//        }
//    }
//}
