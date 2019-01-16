using Identity.Service.Application.Commands.User.Notification;
using Identity.Service.Application.Services.Email;
using Identity.Service.Application.Services.Email.Models;
using System.Threading.Tasks;

namespace Identity.Service.Services.Email
{
    public class EmailConfirmationContentProvider : IEmailContentProvider<UserRegisteredNotification>
    {
        public EmailConfirmationContentProvider(IViewRenderService viewRenderService,
            NotificationConfiguration notificationConfiguration
            )
        {
            this.ViewRenderService = viewRenderService;
            this.Configuration = notificationConfiguration;
        }

        public IViewRenderService ViewRenderService { get; }
        public NotificationConfiguration Configuration { get; }

        public async Task<string> GetEmailContentAsync(UserRegisteredNotification notification)
        {
            var htmlMessage = await this.ViewRenderService.RenderToStringAsync("Account/RegisterConfirmationEmail",
                new RegisterConfirmationEmailViewModel {
                    ConfirmationLink = $"{this.Configuration.EmailConfirmationUrl}?token={System.Uri.EscapeDataString(notification.Token)}&email={notification.User.Email}"
                });

            return htmlMessage;
        }
    }
}
