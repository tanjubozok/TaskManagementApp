namespace TaskManagementApp.Application.Handlers.CategoryHandlers;

public class CategoryDeleteHandler : IRequestHandler<CategoryDeleteRequest, Result<NoData>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryDeleteHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<NoData>> Handle(CategoryDeleteRequest request, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<Category>(request);
        var getCategory = await _unitOfWork.Category.GetByFilterAsync(x => x.Id == category.Id);
        if (getCategory == null)
        {
            return new Result<NoData>(new NoData(), false, "Category not found", null);
        }
        _unitOfWork.Category.Delete(getCategory);
        var result = await _unitOfWork.SaveChangesAsync();
        if (result > 0)
        {
            return new Result<NoData>(new NoData(), true, null, null);
        }
        return new Result<NoData>(new NoData(), false, "An error occurred while deleting the category", null);
    }
}
