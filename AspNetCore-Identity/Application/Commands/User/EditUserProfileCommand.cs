using System.Threading;
using System.Threading.Tasks;
using FluentValidation.Results;
using Identity.Service.Application.Common;
using MediatR;

namespace Identity.Service.Application.Commands.User
{
    /// <summary>
    /// This command updates an user profile and retrieves a result of <see cref="Response{ApplicationUser}"/> type. 
    /// </summary>
    public class EditUserProfileCommand : IRequest<Response<ApplicationUser>>
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        internal class EditUserProfileCommandHandler : IRequestHandler<EditUserProfileCommand, Response<ApplicationUser>>
        {
            public EditUserProfileCommandHandler(ApplicationUserManager userManager)
            {
                this.UserManager = userManager;
            }

            public ApplicationUserManager UserManager { get; }

            public async Task<Response<ApplicationUser>> Handle(EditUserProfileCommand request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByIdAsync(request.UserId);

                if (user == null)
                    return Response<ApplicationUser>.Fail(new ValidationFailure("", $"There is no user that matches the id {request.UserId}."));

                user.UserName = request.Username;
                user.Email = request.Email;
                user.PhoneNumber = request.PhoneNumber;

                var result = await this.UserManager.UpdateAsync(user);

                if (!result.Succeeded)
                    return ResponseHelper.IdentityResultFail<ApplicationUser>(result);

                return Response<ApplicationUser>.Ok(user);
            }
        }
    }
}
