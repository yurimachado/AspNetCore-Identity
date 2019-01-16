using Identity.Service.Application.Commands.User.Notification;
using Identity.Service.Application.Services.Email;
using System.Threading.Tasks;

namespace Identity.Service.Services.Email
{
    public class UserLockoutEmailContentProvider : IEmailContentProvider<UserLockoutNotification>
    {
        public Task<string> GetEmailContentAsync(UserLockoutNotification notification)
        {
            return Task.FromResult("The number of attempts has reached the maximum. Your account has been locked. To unlock your account you will need to reset your password by clicking in 'Forgot Password?'.");
        }
    }
}
