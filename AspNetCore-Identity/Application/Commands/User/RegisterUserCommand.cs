using FluentValidation.Results;
using Identity.Service.Application.Commands.User.Notification;
using Identity.Service.Application.Common;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Service.Application.Commands.User
{
    /// <summary>
    /// This command process the user registration and produce an <see cref="Response{ApplicationUser}"/> as a result.
    /// </summary>
    public class RegisterUserCommand : IRequest<Response<ApplicationUser>>
    {
        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string EmailConfirmationUrl { get; set; }

        internal class RegisterCommandHandler : IRequestHandler<RegisterUserCommand, Response<ApplicationUser>>
        {

            public RegisterCommandHandler(ApplicationUserManager userManager, IMediator mediator)
            {
                this.UserManager = userManager;
                this.Mediator = mediator;
            }

            public ApplicationUserManager UserManager { get; }
            public IMediator Mediator { get; }

            public async Task<Response<ApplicationUser>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
            {
                var user = new ApplicationUser
                {
                    UserName = request.Username.Trim(),
                    NormalizedUserName = request.Username.ToUpper(),
                    Email = request.Email,
                    NormalizedEmail = request.Email.ToUpper(),
                    RoleName = "Guest"
                };

                var result = await this.UserManager.CreateAsync(user, request.Password);

                if (!result.Succeeded)
                    return ResponseHelper.IdentityResultFail<ApplicationUser>(result);

                var token = await this.UserManager.GenerateEmailConfirmationTokenAsync(user);

                if (string.IsNullOrEmpty(token))
                    return Response<ApplicationUser>.Fail(new ValidationFailure("", "The email confirmation token could not be generated."));

                await this.Mediator.Publish(new UserRegisteredNotification { User = user, Token = token });

                return Response<ApplicationUser>.Ok(user);
            }
        }
    }
}
