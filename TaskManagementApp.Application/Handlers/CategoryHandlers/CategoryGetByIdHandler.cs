namespace TaskManagementApp.Application.Handlers.CategoryHandlers;

public class CategoryGetByIdHandler : IRequestHandler<CategoryGetByIdRequest, Result<CategoryUpdateRequest>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryGetByIdHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<CategoryUpdateRequest>> Handle(CategoryGetByIdRequest request, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<Category>(request);
        var getCategory = await _unitOfWork.Category.GetByFilterNoTrackingAsync(x => x.Id == category.Id);
        if (getCategory == null)
        {
            return new Result<CategoryUpdateRequest>(null!, false, "Category not found", null);
        }
        else
        {
            var categoryUpdateRequest = _mapper.Map<CategoryUpdateRequest>(getCategory);
            return new Result<CategoryUpdateRequest>(categoryUpdateRequest, true, null, null);
        }
    }
}
