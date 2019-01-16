using FluentValidation.Results;
using Identity.Service.Application.Commands.User.Notification;
using Identity.Service.Application.Common;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User
{
    /// <summary>
    /// This command produces a <see cref="Response{string}"/> token-based result that can be used to reset a user's password.
    /// </summary>
    public class GenerateResetPasswordTokenCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }

        internal class GenerateResetPasswordTokenCommandHandler : IRequestHandler<GenerateResetPasswordTokenCommand, Response<string>>
        {

            public GenerateResetPasswordTokenCommandHandler(ApplicationUserManager userManager, IMediator mediator)
            {
                this.UserManager = userManager;
                this.Mediator = mediator;
            }

            public ApplicationUserManager UserManager { get; }
            public IMediator Mediator { get; }

            public async Task<Response<string>> Handle(GenerateResetPasswordTokenCommand request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByEmailAsync(request.Email);

                if (user == null)
                    return Response<string>.Fail(new ValidationFailure("", $"There is no user that matches the email address {request.Email}."));

                var token = await this.UserManager.GeneratePasswordResetTokenAsync(user);

                if (string.IsNullOrEmpty(token))
                    return Response<string>.Fail(new ValidationFailure("", "The email confirmation token could not be generated."));

                await this.Mediator.Publish(new PasswordResetHasBeenGeneratedNotification { User = user, Token = token });

                return Response<string>.Ok(token);
            }
        }
    }
}
