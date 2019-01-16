using FluentValidation;
using Identity.Service.Application.Commands.User;

namespace Identity.Service.Application.Validations.Commands.User
{
    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            RuleFor(u => u.Username)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.");

            RuleFor(u => u.Email)
                .NotEmpty()
                .WithName("Email address")
                .WithMessage("{PropertyName} is required.");

            RuleFor(u => u.Password)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.");

            RuleFor(u => u.Password)
                .Equal(u => u.ConfirmPassword)
                .WithName("confirm password")
                .WithMessage("Your Password and confirmation password do not match.");

            RuleFor(u => u.Email)
                .EmailAddress()
                .WithMessage("Email address invalid. Here's an example of a valid one: 'emailname@gmail.com'.");
        }
    }
}
