namespace TaskManagementApp.Application.Handlers.CategoryHandlers;

public class CategoryGetByIdHandler : IRequestHandler<CategoryGetByIdRequest, Result<CategoryUpdateRequest>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryGetByIdHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<Result<CategoryUpdateRequest>> Handle(CategoryGetByIdRequest request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByFilterNoTrackingAsync(x => x.Id == request.Id);
        if (category == null)
        {
            return new Result<CategoryUpdateRequest>(null!, false, "Category not found", null);
        }
        else
        {
            var categoryUpdateRequest = _mapper.Map<CategoryUpdateRequest>(category);
            return new Result<CategoryUpdateRequest>(categoryUpdateRequest, true, null, null);
        }
    }
}
