using FluentValidation.Results;
using Identity.Service.Application.Common;
using Identity.Service.Application.Identity;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User
{
    /// <summary>
    /// This command updates a user and retrives a result of <see cref="Response{ApplicationUser}"/> type.
    /// </summary>
    public class EditUserCommand : IRequest<Response<ApplicationUser>>
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public bool IsBlocked { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool IsAdmin { get; set; }

        internal class EditUserCommandHandler : IRequestHandler<EditUserCommand, Response<ApplicationUser>>
        {
            public EditUserCommandHandler(ApplicationUserManager userManager)
            {
                this.UserManager = userManager;
            }

            public ApplicationUserManager UserManager { get; }

            public async Task<Response<ApplicationUser>> Handle(EditUserCommand request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByIdAsync(request.Id);

                if (user == null)
                    return Response<ApplicationUser>.Fail(new ValidationFailure("", $"There is no user that matches the id {request.Id}."));

                user.UserName = request.Username;
                user.Email = request.Email;
                user.EmailConfirmed = request.EmailConfirmed;
                user.PhoneNumber = request.PhoneNumber;
                user.PhoneNumberConfirmed = request.PhoneNumberConfirmed;
                user.TwoFactorEnabled = request.TwoFactorEnabled;
                user.IsBlocked = request.IsBlocked;
                user.LockoutEnabled = request.LockoutEnabled;
                if (request.IsAdmin)
                    user.RoleName = "Admin";
                else
                    user.RoleName = "Guest";

                var result = await this.UserManager.UpdateAsync(user);

                if (!result.Succeeded)
                    return ResponseHelper.IdentityResultFail<ApplicationUser>(result);

                return Response<ApplicationUser>.Ok(user);
            }
        }
    }
}
