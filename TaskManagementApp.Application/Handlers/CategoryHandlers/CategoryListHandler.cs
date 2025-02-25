namespace TaskManagementApp.Application.Handlers.CategoryHandlers;

public class CategoryListHandler : IRequestHandler<CategoryListRequest, Result<List<CategoryListDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryListHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<List<CategoryListDto>>> Handle(CategoryListRequest request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.Category.GetAllsync();
        var categoryList = _mapper.Map<List<CategoryListDto>>(result);

        return new Result<List<CategoryListDto>>(categoryList, true, null, null);
    }
}
