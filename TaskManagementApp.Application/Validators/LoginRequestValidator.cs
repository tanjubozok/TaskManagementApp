﻿namespace TaskManagementApp.Application.Validators;

public class LoginRequestValidator : AbstractValidator<LoginRequst>
{
    public LoginRequestValidator()
    {
        RuleFor(x => x.Username)
            .NotEmpty().WithMessage("Username is required")
            .MinimumLength(3).WithMessage("Username must be at least 3 characters long")
            .MaximumLength(64).WithMessage("Username must be at most 64 characters long");

        RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters long")
            .MaximumLength(64).WithMessage("Password must be at most 64 characters long");
    }
}
