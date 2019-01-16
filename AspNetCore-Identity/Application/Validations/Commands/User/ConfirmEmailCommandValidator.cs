using FluentValidation;
using Identity.Service.Application.Commands.User;

namespace Identity.Service.Application.Validations.Commands.User
{
    public class ConfirmEmailCommandValidator : AbstractValidator<ConfirmEmailCommand>
    {
        public ConfirmEmailCommandValidator()
        {
            RuleFor(u => u.Email)
                .NotEmpty()
                .WithMessage("{PropertyName} is required.");

            RuleFor(u => u.Email)
                .EmailAddress()
                .WithMessage("Email address invalid. Here's an example of a valid one: 'emailname@gmail.com'.");

            RuleFor(u => u.ConfirmEmailToken)
                .NotEmpty()
                .WithName("Confirm Email Token")
                .WithMessage("{PropertyName} is required.");
        }
    }
}
