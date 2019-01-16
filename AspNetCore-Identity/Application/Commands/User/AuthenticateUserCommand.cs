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
    /// This command authenticates an user, retrieves an <see cref="ApplicationUser"/> and list of <see cref="ValidationFailure"/>.
    /// </summary>
    public class AuthenticateUserCommand : IRequest<Response<ApplicationUser>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
            
        internal class AuthenticateUserCommandHandler : IRequestHandler<AuthenticateUserCommand, Response<ApplicationUser>>
        {

            public AuthenticateUserCommandHandler(ApplicationUserManager userManager, IMediator mediator)
            {
                this.UserManager = userManager;
                this.Mediator = mediator;
            }

            public ApplicationUserManager UserManager { get; }
            public IMediator Mediator { get; }

            public async Task<Response<ApplicationUser>> Handle(AuthenticateUserCommand request, CancellationToken cancellationToken)
            {
                var user = await this.UserManager.FindByNameAsync(request.Username);

                if (user != null)
                {
                    if (!await this.UserManager.IsEmailConfirmedAsync(user) && !await this.UserManager.IsPhoneNumberConfirmedAsync(user))
                        return Response<ApplicationUser>.Fail(new ValidationFailure("", "Please confirm your registration. Check your Email or Phone and click the link we sent to you."));

                    if (await this.UserManager.IsLockedOutAsync(user))
                        return Response<ApplicationUser>.Fail(new ValidationFailure("Password", "The maximum number of attempts has been reached. Please click in Forgot password to reset your password."));

                    var isPasswordValid = await this.UserManager.CheckPasswordAsync(user, request.Password);

                    if (isPasswordValid) {
                        await this.UserManager.ResetAccessFailedCountAsync(user);
                        await this.Mediator.Publish(new UserLoggedInNotification { User = user, DatetimeUserLoggedIn = DateTime.UtcNow });
                        return Response<ApplicationUser>.Ok(user);
                    }

                    await this.UserManager.AccessFailedAsync(user);

                    if (await this.UserManager.IsLockedOutAsync(user))
                    {
                        await this.Mediator.Publish(new UserLockoutNotification { User = user, DatetimeOfLockout = DateTime.UtcNow });
                        return Response<ApplicationUser>.Fail(new ValidationFailure("Password", "Invalid username or password. The maximum number of attempts has been reached. Please click in Forgot password to reset your password."));
                    }
                }

                await this.Mediator.Publish(new AccessFailedNotification { User = user, DatetimeAccessFailed = DateTime.UtcNow });
                return Response<ApplicationUser>.Fail(new ValidationFailure("Password", "Invalid username or password."));
            }
        }
    }
}
