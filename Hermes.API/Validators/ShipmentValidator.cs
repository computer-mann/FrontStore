using FluentValidation;
using FrontStore.Application.DTOs;

namespace FrontStore.API.Validators;

public class ShipmentValidator : AbstractValidator<Shipment>
{
    public ShipmentValidator()
    {
        RuleFor(x => x.TrackingNumber)
            .NotEmpty().WithMessage("Tracking number is required.");

        RuleFor(x => x.ShippingLabelUrls)
            .NotEmpty().WithMessage("Shipping label URLs are required.");
    }
}