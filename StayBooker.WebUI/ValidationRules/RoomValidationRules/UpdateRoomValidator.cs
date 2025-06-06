using FluentValidation;
using StayBooker.WebUI.Dtos.RoomDtos;

namespace StayBooker.WebUI.ValidationRules.RoomValidationRules
{
    public class UpdateRoomValidator : AbstractValidator<UpdateRoomDto>
    {
        public UpdateRoomValidator()
        {
            RuleFor(x => x.RoomTitle)
            .NotEmpty().WithMessage("Room title is required.")
            .MaximumLength(100).WithMessage("Room title must not exceed 100 characters.");

            RuleFor(x => x.RoomNumber)
                .NotEmpty().WithMessage("Room number is required.")
                .MaximumLength(10).WithMessage("Room number must not exceed 10 characters.")
                .Matches("^[a-zA-Z0-9]+$").WithMessage("Room number must contain only letters and numbers.");

            RuleFor(x => x.RoomCoverImage)
                .NotEmpty().WithMessage("Room cover image is required.")
                .WithMessage("Room cover image must be a valid URL.");

            RuleFor(x => x.RoomPrice)
                .GreaterThan(0).WithMessage("Room price must be greater than 0.");

            RuleFor(x => x.RoomBadCount)
                .NotEmpty().WithMessage("Bed count is required.")
                .Matches("^[0-9]+$").WithMessage("Bed count must be a number.");

            RuleFor(x => x.RoomBathCount)
                .NotEmpty().WithMessage("Bathroom count is required.")
                .Matches("^[0-9]+$").WithMessage("Bathroom count must be a number.");

            RuleFor(x => x.RoomWifi)
                .NotEmpty().WithMessage("Wi-Fi information is required.")
                .Must(wifi => wifi.ToLower() == "yes" || wifi.ToLower() == "no")
                .WithMessage("Wi-Fi must be either 'Yes' or 'No'.");

            RuleFor(x => x.RoomDescription)
                .NotEmpty().WithMessage("Room description is required.")
                .MaximumLength(500).WithMessage("Room description must not exceed 500 characters.");
        }
    }
}
