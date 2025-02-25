namespace TaskManagementApp.Application.Validators.CategoryValidators;

public class CategoryUpdateRequestValidator : AbstractValidator<CategoryUpdateRequest>
{
    public CategoryUpdateRequestValidator()
    {
        RuleFor(x => x.Definition)
            .NotEmpty().WithMessage("Category definition is required")
            .MinimumLength(3).WithMessage("Category definition must be at least 3 characters")
            .MaximumLength(128).WithMessage("Category definition must be less than 100 characters");
    }
}
