using Identity.Service.Application.Services.Email;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User.Notification
{
    public class SendPasswordResetTokenEmailHandler : INotificationHandler<PasswordResetHasBeenGeneratedNotification>
    {
        public SendPasswordResetTokenEmailHandler(ApplicationUserManager userManager, 
            NotificationConfiguration notificationConfiguration,
            IEmailSender emailSender,
            IEmailContentProvider<PasswordResetHasBeenGeneratedNotification> emailContentProvider)
        {
            this.UserManager = userManager;
            this.Configuration = notificationConfiguration;
            this.EmailSender = emailSender;
            this.EmailContentProvider = emailContentProvider;
        }

        public ApplicationUserManager UserManager { get; }
        public NotificationConfiguration Configuration { get; }
        public IEmailSender EmailSender { get; }
        public IEmailContentProvider<PasswordResetHasBeenGeneratedNotification> EmailContentProvider { get; }

        public Task Handle(PasswordResetHasBeenGeneratedNotification notification, CancellationToken cancellationToken)
        {
            this.EmailSender.SendEmailAsync(notification.User.Email, "Reset Password", this.EmailContentProvider.GetEmailContentAsync(notification).Result);

            return Task.CompletedTask;
        }
    }
}
