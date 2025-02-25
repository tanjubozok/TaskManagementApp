namespace TaskManagementApp.Application.Validators.CategoryValidators;

public class CategoryCreateRequestValidator : AbstractValidator<CategoryCreateRequst>
{
    public CategoryCreateRequestValidator()
    {
        RuleFor(x => x.Definition)
            .NotEmpty().WithMessage("Category definition is required")
            .MinimumLength(3).WithMessage("Category definition must be at least 3 characters")
            .MaximumLength(100).WithMessage("Category definition must be less than 100 characters");
    }
}
