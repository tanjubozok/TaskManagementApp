using FluentValidation;
using TaskManagementApp.Application.Requests;

namespace TaskManagementApp.Application.Validators;

public class LoginRequestValidator : AbstractValidator<LoginRequst>
{
    public LoginRequestValidator()
    {
        RuleFor(x => x.Username).NotEmpty().WithMessage("Username is required");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
    }
}
