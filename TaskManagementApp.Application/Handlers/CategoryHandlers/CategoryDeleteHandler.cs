namespace TaskManagementApp.Application.Handlers.CategoryHandlers;

public class CategoryDeleteHandler : IRequestHandler<CategoryDeleteRequest, Result<NoData>>
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryDeleteHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Result<NoData>> Handle(CategoryDeleteRequest request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByFilterAsync(x => x.Id == request.Id);
        if (category == null)
        {
            return new Result<NoData>(new NoData(), false, "Category not found", null);
        }
        await _categoryRepository.DeleteAsync(category);
        return new Result<NoData>(new NoData(), true, null, null);
    }
}
