//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Identity.Service.Application
//{
//    public class InMemoryUserStore :
//        IUserPasswordStore<ApplicationUser>,
//        IUserLockoutStore<ApplicationUser>,
//        IUserEmailStore<ApplicationUser>,
//        IUserRoleStore<ApplicationUser>
//        //IUserClaimStore<ApplicationUser>
//    {
//        private IRepository<ApplicationUser, string> _userRepository;
//        private IRepository<IdentityRole, string> _roleRepository;

//        public InMemoryUserStore(IRepository<ApplicationUser, string> userRepository, IRepository<IdentityRole, string> roleRepository)
//        {
//            this._userRepository = userRepository;
//            this._roleRepository = roleRepository;
//        }

//        private IdentityResult UserExists(ApplicationUser user)
//        {
//            var userFound = this._userRepository.FindByKey(user.Id);
//            if (userFound == null)
//                return IdentityResult.Failed(new IdentityError[] {
//                    new IdentityError { Code = "0x80131577", Description = "Key Not Found." }
//                });
//            return IdentityResult.Success;
//        }

//        public Task<string> GetUserIdAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.Query(u => u.UserName == user.UserName).FirstOrDefault();

//            if (entity == null)
//                return Task.FromResult(user.Id);

//            return Task.FromResult(entity.Id);
//        }

//        public Task<string> GetUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);
//            if (entity == null)
//                return Task.FromResult(user.UserName);

//            return Task.FromResult(entity.UserName);
//        }

//        public Task SetUserNameAsync(ApplicationUser user, string userName, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);
//            user.UserName = userName;

//            if (entity != null)
//                entity.UserName = userName;

//            return Task.CompletedTask;
//        }

//        public Task<string> GetNormalizedUserNameAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.Query(u => u.Id == user.Id).FirstOrDefault();
//            if (entity == null)
//                return Task.FromResult(user.NormalizedUserName);

//            return Task.FromResult(entity.NormalizedUserName);
//        }

//        public Task SetNormalizedUserNameAsync(ApplicationUser user, string normalizedName, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.Query(u => u.NormalizedUserName == normalizedName).FirstOrDefault();
//            user.NormalizedUserName = normalizedName;

//            if (entity != null)
//                entity.NormalizedUserName = normalizedName;

//            return Task.CompletedTask;
//        }

//        public Task<IdentityResult> CreateAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.Query(u => u.UserName == user.UserName || u.Email == user.Email || u.PhoneNumber == user.PhoneNumber).FirstOrDefault();
//            if (entity != null)
//            {
//                return Task.FromResult(IdentityResult.Failed(new IdentityError[] {
//                    new IdentityError { Code = "11000", Description = "Duplicate User. The Username, Email and Phone Number are Unique." }
//                }));
//            }

//            this._userRepository.Add(user);

//            return Task.FromResult(IdentityResult.Success);
//        }

//        public Task<IdentityResult> UpdateAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var result = UserExists(user);

//            if (!result.Succeeded)
//                return Task.FromResult(result);

//            this._userRepository.Update(user);
            
//            return Task.FromResult(result);
//        }

//        public Task<IdentityResult> DeleteAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var result = UserExists(user);

//            if (!result.Succeeded)
//                return Task.FromResult(result);

//            this._userRepository.Remove(user);

//            return Task.FromResult(result);
//        }

//        Task<ApplicationUser> IUserStore<ApplicationUser>.FindByIdAsync(string userId, CancellationToken cancellationToken)
//        {
//            return Task.FromResult(this._userRepository.FindByKey(userId));
//        }

//        Task<ApplicationUser> IUserStore<ApplicationUser>.FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
//        {
//            return Task.FromResult(this._userRepository.Query(u => u.NormalizedUserName == normalizedUserName).FirstOrDefault());
//        }

//        public void Dispose()
//        {
//            //this.Dispose();
//        }

//        public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            user.PasswordHash = passwordHash;

//            if (entity != null)
//                entity.PasswordHash = passwordHash;

//            return Task.CompletedTask;
//        }

//        public Task<string> GetPasswordHashAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                return Task.FromResult(user.PasswordHash);

//            return Task.FromResult(entity.PasswordHash);
//        }

//        public Task<bool> HasPasswordAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                return Task.FromResult(false);

//            return Task.FromResult(entity.PasswordHash != null);
//        }

//        public Task<DateTimeOffset?> GetLockoutEndDateAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                return Task.FromResult(user.LockoutEnd);

//            return Task.FromResult(entity.LockoutEnd);
//        }

//        public Task SetLockoutEndDateAsync(ApplicationUser user, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                user.LockoutEnd = lockoutEnd;
//            else
//                entity.LockoutEnd = lockoutEnd;

//            return Task.CompletedTask;
//        }

//        public Task<int> IncrementAccessFailedCountAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);
//            int currentAccessFailedCount;
//            if (entity == null)
//                currentAccessFailedCount = user.AccessFailedCount += 1;
//            else
//                currentAccessFailedCount = entity.AccessFailedCount += 1;

//            return Task.FromResult(currentAccessFailedCount);
//        }

//        public Task ResetAccessFailedCountAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);
//            if (entity == null)
//                user.AccessFailedCount = 0;
//            else
//                entity.AccessFailedCount = 0;

//            return Task.CompletedTask;
//        }

//        public Task<int> GetAccessFailedCountAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                return Task.FromResult(user.AccessFailedCount);

//            return Task.FromResult(entity.AccessFailedCount);
//        }

//        public Task<bool> GetLockoutEnabledAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                return Task.FromResult(user.LockoutEnabled);

//            return Task.FromResult(entity.LockoutEnabled);
//        }

//        public Task SetLockoutEnabledAsync(ApplicationUser user, bool enabled, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                user.LockoutEnabled = enabled;
//            else
//                entity.LockoutEnabled = enabled;

//            return Task.CompletedTask;
//        }

//        public Task SetEmailAsync(ApplicationUser user, string email, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                user.Email = email;
//            else
//                entity.Email = email;

//            return Task.CompletedTask;
//        }

//        public Task<string> GetEmailAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                return Task.FromResult(user.Email);

//            return Task.FromResult(entity.Email);
//        }

//        public Task<bool> GetEmailConfirmedAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                return Task.FromResult(user.EmailConfirmed);

//            return Task.FromResult(entity.EmailConfirmed);
//        }

//        public Task SetEmailConfirmedAsync(ApplicationUser user, bool confirmed, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                user.EmailConfirmed = confirmed;
//            else
//                entity.EmailConfirmed = confirmed;

//            return Task.CompletedTask;
//        }

//        public Task<ApplicationUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.Query(u => u.NormalizedEmail == normalizedEmail).FirstOrDefault();

//            return Task.FromResult(entity);
//        }

//        public Task<string> GetNormalizedEmailAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                return Task.FromResult(user.NormalizedEmail);

//            return Task.FromResult(entity.NormalizedEmail);
//        }

//        public Task SetNormalizedEmailAsync(ApplicationUser user, string normalizedEmail, CancellationToken cancellationToken)
//        {
//            var entity = this._userRepository.FindByKey(user.Id);

//            if (entity == null)
//                user.NormalizedEmail = normalizedEmail;
//            else
//                entity.NormalizedEmail = normalizedEmail;

//            return Task.CompletedTask;
//        }

//        public Task AddToRoleAsync(ApplicationUser user, string roleName, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }

//        public Task RemoveFromRoleAsync(ApplicationUser user, string roleName, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IList<string>> GetRolesAsync(ApplicationUser user, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();

//        }

//        public Task<bool> IsInRoleAsync(ApplicationUser user, string roleName, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IList<ApplicationUser>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
