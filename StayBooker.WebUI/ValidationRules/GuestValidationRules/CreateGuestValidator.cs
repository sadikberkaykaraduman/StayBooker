using FluentValidation;
using StayBooker.WebUI.Dtos.GuestDtos;

namespace StayBooker.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.GuestName)
            .NotEmpty().WithMessage("Guest name is required.")
            .MaximumLength(50).WithMessage("Guest name must not exceed 50 characters.")
            .Matches("^[a-zA-Z]+$").WithMessage("Guest name must contain only letters.");

            RuleFor(x => x.GuestSurname)
                .NotEmpty().WithMessage("Guest surname is required.")
                .MaximumLength(50).WithMessage("Guest surname must not exceed 50 characters.")
                .Matches("^[a-zA-Z]+$").WithMessage("Guest surname must contain only letters.");

            RuleFor(x => x.GuestCity)
                .NotEmpty().WithMessage("Guest city is required.")
                .MaximumLength(100).WithMessage("Guest city must not exceed 100 characters.");
        }
    }
}
