using Identity.Service.Application.Services.Email;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User.Notification
{
    public class SendUserLockoutEmailHandler : INotificationHandler<UserLockoutNotification>
    {
        public SendUserLockoutEmailHandler(ApplicationUserManager userManager, 
            IEmailSender emailSender,
            IEmailContentProvider<UserLockoutNotification> emailContentProvider)
        {
            this.UserManager = userManager;
            this.EmailSender = emailSender;
            this.EmailContentProvider = emailContentProvider;
        }

        public ApplicationUserManager UserManager { get; }
        public IEmailSender EmailSender { get; }
        public IEmailContentProvider<UserLockoutNotification> EmailContentProvider { get; }

        public Task Handle(UserLockoutNotification notification, CancellationToken cancellationToken)
        {
            this.EmailSender.SendEmailAsync(notification.User.Email, "Account Blocked", this.EmailContentProvider.GetEmailContentAsync(notification).Result);

            return Task.CompletedTask;
        }
    }
}
