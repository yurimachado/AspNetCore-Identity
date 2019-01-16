using FluentValidation;
using Identity.Service.Application.Commands.User;

namespace Identity.Service.Application.Validations.Commands.User
{
    public class AuthenticateUserCommandValidator : AbstractValidator<AuthenticateUserCommand>
    {
        public AuthenticateUserCommandValidator()
        {
            RuleFor(u => u.Password)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.");

            RuleFor(u => u.Username)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.");
        }
    }
}
