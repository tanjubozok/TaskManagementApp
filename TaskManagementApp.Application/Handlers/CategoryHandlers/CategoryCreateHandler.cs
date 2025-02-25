namespace TaskManagementApp.Application.Handlers.CategoryHandlers;

public class CategoryCreateHandler : IRequestHandler<CategoryCreateRequst, Result<NoData>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryCreateHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<Result<NoData>> Handle(CategoryCreateRequst request, CancellationToken cancellationToken)
    {
        var validationResult = new CategoryCreateRequestValidator().Validate(request);
        if (validationResult.IsValid)
        {
            var category = _mapper.Map<Category>(request);
            var result = await _categoryRepository.CreateAsync(category);
            if (result > 0)
                return new Result<NoData>(new NoData(), true, null, null);
            else
                return new Result<NoData>(new NoData(), false, "An error occurred while creating the category", null);
        }
        else
        {
            var errors = validationResult.Errors.ToMap();
            return new Result<NoData>(new NoData(), false, "Validation Errors", errors);
        }
    }
}
