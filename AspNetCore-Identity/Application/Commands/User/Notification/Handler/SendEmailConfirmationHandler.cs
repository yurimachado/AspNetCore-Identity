using Identity.Service.Application.Services.Email;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User.Notification
{
    public class SendEmailConfirmationHandler : INotificationHandler<UserRegisteredNotification>
    {
        public SendEmailConfirmationHandler(ApplicationUserManager userManager, 
            NotificationConfiguration notificationConfiguration,
            IEmailSender emailSender,
            IEmailContentProvider<UserRegisteredNotification> emailContentProvider)
        {
            this.UserManager = userManager;
            this.Configuration = notificationConfiguration;
            this.EmailSender = emailSender;
            this.EmailContentProvider = emailContentProvider;
        }

        public ApplicationUserManager UserManager { get; }
        public NotificationConfiguration Configuration { get; }
        public IEmailSender EmailSender { get; }
        public IEmailContentProvider<UserRegisteredNotification> EmailContentProvider { get; }

        public Task Handle(UserRegisteredNotification notification, CancellationToken cancellationToken)
        {
            this.EmailSender.SendEmailAsync(notification.User.Email, "Email Confirmation", this.EmailContentProvider.GetEmailContentAsync(notification).Result);

            return Task.CompletedTask;
        }
    }
}
