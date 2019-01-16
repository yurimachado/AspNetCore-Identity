using FluentValidation;
using Identity.Service.Application.Commands.User;

namespace Identity.Service.Application.Validations.Commands.User
{
    public class GenerateConfirmPasswordTokenCommandValidator : AbstractValidator<GenerateConfirmPasswordTokenCommand>
    {
        public GenerateConfirmPasswordTokenCommandValidator()
        {
            RuleFor(u => u.Email)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.");

            RuleFor(u => u.Email)
                .EmailAddress()
                .WithMessage("Email address invalid. Here's an example of a valid one: 'emailname@gmail.com'.");
        }
    }
}
