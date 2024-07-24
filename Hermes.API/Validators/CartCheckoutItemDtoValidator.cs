﻿using FluentValidation;
using FrontStore.Application.DTOs;

namespace FrontStore.API.Validators;

public class CartCheckoutItemDtoValidator : AbstractValidator<CartCheckoutItemDto>
{
    public CartCheckoutItemDtoValidator()
    {
        RuleFor(x => x.ProductName)
            .NotEmpty().WithMessage("Product name is required.");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Price must be greater than 0.");

        RuleFor(x => x.Quantity)
            .GreaterThanOrEqualTo(1).WithMessage("Quantity must be at least 1.");
    }
}