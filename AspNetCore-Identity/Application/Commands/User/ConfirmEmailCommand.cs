using FluentValidation.Results;
using Identity.Service.Application.Common;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User
{
    /// <summary>
    /// This command checks whether an email confirmation token is valid or not.
    /// </summary>
    public class ConfirmEmailCommand : IRequest<Response<bool>>
    {
        public string Email { get; set; }

        public string ConfirmEmailToken { get; set; }

        internal class ConfirmUserRegistrationCommandHandler : IRequestHandler<ConfirmEmailCommand, Response<bool>>
        {

            public ConfirmUserRegistrationCommandHandler(ApplicationUserManager userManager)
            {
                this.UserManager = userManager;
            }

            public ApplicationUserManager UserManager { get; }

            public async Task<Response<bool>> Handle(ConfirmEmailCommand request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByEmailAsync(request.Email);

                if (user == null)
                    return Response<bool>.Fail(new ValidationFailure("", $"There is no user that matches the email address {request.Email}."));

                var result = await this.UserManager.ConfirmEmailAsync(user, request.ConfirmEmailToken);

                if (result.Succeeded)
                    return Response<bool>.Ok();

                return ResponseHelper.IdentityResultFail<bool>(result);
            }
        }
    }
}
