namespace TaskManagementApp.Application.Handlers.CategoryHandlers;

public class CategoryListHandler : IRequestHandler<CategoryListRequest, Result<List<CategoryListDto>>>
{
    private readonly ICategoryRepository _category;
    private readonly IMapper _mapper;

    public CategoryListHandler(ICategoryRepository category, IMapper mapper)
    {
        _category = category;
        _mapper = mapper;
    }

    public async Task<Result<List<CategoryListDto>>> Handle(CategoryListRequest request, CancellationToken cancellationToken)
    {
        var result = await _category.GetAllsync();
        var categoryList = _mapper.Map<List<CategoryListDto>>(result);

        return new Result<List<CategoryListDto>>(categoryList, true, null, null);
    }
}
