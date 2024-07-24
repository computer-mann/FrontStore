using FluentValidation;
using FrontStore.Application.DTOs;

namespace FrontStore.API.Validators;

public class RefreshTokenDtoValidator : AbstractValidator<RefreshTokenDto>
{
    public RefreshTokenDtoValidator()
    {
        RuleFor(x => x.Token)
            .NotEmpty().WithMessage("Refresh token is required.");
    }
}