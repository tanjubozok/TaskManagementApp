namespace TaskManagementApp.Application.Handlers.CategoryHandlers;

public class CategoryUpdateHandler : IRequestHandler<CategoryUpdateRequest, Result<NoData>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryUpdateHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<Result<NoData>> Handle(CategoryUpdateRequest request, CancellationToken cancellationToken)
    {
        var validationResult = new CategoryUpdateRequestValidator().Validate(request);
        if (validationResult.IsValid)
        {
            var category = _mapper.Map<Category>(request);
            var existingCategory = await _categoryRepository.GetByFilterAsync(x => x.Id == category.Id);
            if (existingCategory == null)
                return new Result<NoData>(new NoData(), false, "Category not found", null);

            existingCategory.Definition = category.Definition;

            var result = await _categoryRepository.UpdateAsync(existingCategory);
            if (result > 0)
                return new Result<NoData>(new NoData(), true, null, null);
            else
                return new Result<NoData>(new NoData(), false, "An error occurred while updating the category", null);
        }
        else
        {
            var errors = validationResult.Errors.ToMap();
            return new Result<NoData>(new NoData(), false, "Validation Errors", errors);
        }
    }
}
