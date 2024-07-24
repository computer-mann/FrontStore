using FluentValidation;
using FrontStore.Application.DTOs;

namespace FrontStore.API.Validators;

public class TrackingEventValidator : AbstractValidator<TrackingEvent>
{
    public TrackingEventValidator()
    {
        RuleFor(x => x.Timestamp)
            .NotEmpty().WithMessage("Timestamp is required.");

        RuleFor(x => x.Location)
            .NotEmpty().WithMessage("Location is required.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required.");
    }
}