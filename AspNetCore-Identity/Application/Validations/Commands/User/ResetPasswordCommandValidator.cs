using FluentValidation;
using Identity.Service.Application.Commands.User;

namespace Identity.Service.Application.Validations.Commands.User
{
    public class ResetPasswordCommandValidator : AbstractValidator<ResetPasswordCommand>
    {
        public ResetPasswordCommandValidator()
        {
            RuleFor(u => u.ResetPasswordToken)
                .NotEmpty()
                .WithName("Reset Password Token")
                .WithMessage("{PropertyName} is required.");

            RuleFor(u => u.Email)
                .NotEmpty()
                .WithName("Email address")
                .WithMessage("{PropertyName} is required.");

            RuleFor(u => u.NewPassword)
                .NotEmpty()
                .WithName("new password")
                .WithMessage("{PropertyName} is required.");

            RuleFor(u => u.ConfirmNewPassword)
                .Equal(u => u.NewPassword)
                .WithName("confirm password")
                .WithMessage("Your new Password and confirmation password do not match.");

            RuleFor(u => u.Email)
                .EmailAddress()
                .WithMessage("Email address invalid. Here's an example of a valid one: 'emailname@gmail.com'.");
        }
    }
}
