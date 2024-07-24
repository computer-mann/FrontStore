using FluentValidation;
using FrontStore.Application.DTOs;

namespace FrontStore.API.Validators;

public class CartItemDtoValidator : AbstractValidator<CartItemDto>
{
    public CartItemDtoValidator()
    {
        RuleFor(x => x.Quantity)
            .GreaterThanOrEqualTo(1).WithMessage("Quantity must be at least 1.");
    }
}