using FluentValidation.Results;
using Identity.Service.Application.Common;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User
{
    // This command reset an user's password with a new one and produces a boolean result indicating whether the operation has succeeded or not.
    public class ResetPasswordCommand : IRequest<Response<bool>>
    {
        public string Email { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
        public string ResetPasswordToken { get; set; }

        internal class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand, Response<bool>>
        {
            public ResetPasswordCommandHandler(ApplicationUserManager userManager)
            {
                this.UserManager = userManager;
            }

            public ApplicationUserManager UserManager { get; }

            public async Task<Response<bool>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByEmailAsync(request.Email);

                if (user == null)
                    return Response<bool>.Fail(new ValidationFailure("Email", $"There is no user that matches the email address {request.Email}."));

                var result = await this.UserManager.ResetPasswordAsync(user, request.ResetPasswordToken, request.NewPassword);

                if (!result.Succeeded)
                    return ResponseHelper.IdentityResultFail<bool>(result);

                if (await this.UserManager.IsLockedOutAsync(user))
                    await this.UserManager.SetLockoutEndDateAsync(user, DateTimeOffset.UtcNow);

                return Response<bool>.Ok(true);

            }
        }
    }
}
