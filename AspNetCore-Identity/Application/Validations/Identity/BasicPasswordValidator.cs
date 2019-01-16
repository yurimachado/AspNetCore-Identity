using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Identity.Service.Application.Validations.Identity
{
    public class BasicPasswordValidator<TUser> : IPasswordValidator<TUser> where TUser : class
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user, string password)
        {
            var username = await manager.GetEmailAsync(user);

            if (username == password)
                return IdentityResult.Failed(new IdentityError { Description = "Password can not contain username" });
            if (password.Contains("password"))
                return IdentityResult.Failed(new IdentityError { Description = "Password can not contain password" });

            return IdentityResult.Success;
        }
    }
}
