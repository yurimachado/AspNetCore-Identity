using FluentValidation.Results;
using Identity.Service.Application.Commands.User.Notification;
using Identity.Service.Application.Common;
using Identity.Service.Application.Services.Email;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User
{
    public class ResendEmailConfirmationCommand : IRequest<Response<ApplicationUser>>
    {
        public string Email { get; set; }

        internal class ResendEmailConfirmationHandler : IRequestHandler<ResendEmailConfirmationCommand, Response<ApplicationUser>>
        {
            public ResendEmailConfirmationHandler(ApplicationUserManager userManager, 
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

            public async Task<Response<ApplicationUser>> Handle(ResendEmailConfirmationCommand request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByEmailAsync(request.Email);

                if (user == null)
                    return Response<ApplicationUser>.Fail(new ValidationFailure("Email", $"The email address {request.Email} no longer exists."));

                var token = this.UserManager.GenerateEmailConfirmationTokenAsync(user).Result;

                if (!string.IsNullOrEmpty(token))
                    await this.EmailSender.SendEmailAsync(user.Email, 
                        "Email Confirmation", 
                        this.EmailContentProvider.GetEmailContentAsync(new UserRegisteredNotification { User = user, Token = token }).Result);

                return Response<ApplicationUser>.Ok(user);
            }
        }
    }
}
