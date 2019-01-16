using Identity.Service.Application.Common;
using Identity.Service.Application.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User
{
    /// <summary>
    /// This command creates a user and retrives a result of <see cref="Response{ApplicationUser}"/> type.
    /// </summary>
    public class CreateUserCommand : IRequest<Response<ApplicationUser>>
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
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsAdmin { get; set; }

        internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Response<ApplicationUser>>
        {
            public CreateUserCommandHandler(ApplicationUserManager userManager)
            {
                this.UserManager = userManager;
            }

            public ApplicationUserManager UserManager { get; }

            public async Task<Response<ApplicationUser>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
            {
                var user = new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = request.Username.Trim(),
                    NormalizedUserName = request.Username.ToUpper(),
                    Email = request.Email,
                    NormalizedEmail = request.Email.ToUpper(),
                    EmailConfirmed = request.EmailConfirmed,
                    PhoneNumber = request.PhoneNumber,
                    PhoneNumberConfirmed = request.PhoneNumberConfirmed,
                    TwoFactorEnabled = request.TwoFactorEnabled,
                    IsBlocked = request.IsBlocked,
                    LockoutEnabled = request.LockoutEnabled
                };

                if (request.IsAdmin)
                    user.RoleName = "Admin";

                var result = await this.UserManager.CreateAsync(user, request.Password);

                if (!result.Succeeded)
                    return ResponseHelper.IdentityResultFail<ApplicationUser>(result);

                return Response<ApplicationUser>.Ok(user);
            }
        }
    }
}
