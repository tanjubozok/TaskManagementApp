namespace TaskManagementApp.Application.Validators;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        RuleFor(x => x.Username)
            .NotEmpty().WithMessage("Username is required.")
            .MinimumLength(3).WithMessage("Username must be at least 3 characters long.")
            .MaximumLength(64).WithMessage("Username must be at most 64 characters long.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MinimumLength(6).WithMessage("Password must be at least 6 characters long.")
            .MaximumLength(64).WithMessage("Password must be at most 64 characters long.");

        RuleFor(x => x.RePassword)
            .Equal(x => x.Password).WithMessage("Passwords do not match.");

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MinimumLength(2).WithMessage("Name must be at least 2 characters long.")
            .MaximumLength(64).WithMessage("Name must be at most 64 characters long.");

        RuleFor(x => x.Surname)
            .NotEmpty().WithMessage("Surname is required.")
            .MinimumLength(2).WithMessage("Surname must be at least 2 characters long.")
            .MaximumLength(64).WithMessage("Surname must be at most 64 characters long.");
    }
}
