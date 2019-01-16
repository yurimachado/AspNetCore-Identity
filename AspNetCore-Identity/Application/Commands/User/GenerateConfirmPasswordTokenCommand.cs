using FluentValidation.Results;
using Identity.Service.Application.Common;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User
{
    /// <summary>
    /// This command produces a <see cref="Response{string}"/> token-based result that can be used to confirm a user registration.
    /// </summary>
    public class GenerateConfirmPasswordTokenCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }

        internal class GenerateConfirmPasswordTokenCommandHandler : IRequestHandler<GenerateConfirmPasswordTokenCommand, Response<string>>
        {

            public GenerateConfirmPasswordTokenCommandHandler(ApplicationUserManager userManager)
            {
                this.UserManager = userManager;
            }

            public ApplicationUserManager UserManager { get; }

            public async Task<Response<string>> Handle(GenerateConfirmPasswordTokenCommand request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByEmailAsync(request.Email);

                if (user == null)
                    return Response<string>.Fail(new ValidationFailure("", $"There is no user that matches the email address {request.Email}."));

                var token = await this.UserManager.GenerateEmailConfirmationTokenAsync(user);

                if (string.IsNullOrEmpty(token))
                    return Response<string>.Fail(new ValidationFailure("", "The email confirmation token could not be generated."));

                return Response<string>.Ok(token);
            }
        }
    }
}
