using Identity.Service.Application.Commands.User.Notification;
using Identity.Service.Application.Services.Email;
using Identity.Service.Application.Services.Email.Models;
using System.Threading.Tasks;

namespace Identity.Service.Services.Email
{
    public class ResetPasswordEmailContentProvider : IEmailContentProvider<PasswordResetHasBeenGeneratedNotification>
    {
        public ResetPasswordEmailContentProvider(IViewRenderService viewRenderService,
            NotificationConfiguration notificationConfiguration
            )
        {
            this.ViewRenderService = viewRenderService;
            this.Configuration = notificationConfiguration;
        }

        public IViewRenderService ViewRenderService { get; }
        public NotificationConfiguration Configuration { get; }

        public async Task<string> GetEmailContentAsync(PasswordResetHasBeenGeneratedNotification notification)
        {
            var htmlMessage = await this.ViewRenderService.RenderToStringAsync("Account/ResetPasswordEmail",
                new ResetPasswordEmailViewModel {
                    ResetLink = $"{this.Configuration.ResetPassowordUrl}?token={System.Uri.EscapeDataString(notification.Token)}&email={notification.User.Email}"
                });

            return htmlMessage;
        }
    }
}
