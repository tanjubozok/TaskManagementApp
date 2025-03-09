namespace TaskManagementApp.Application.Handlers.AppTaskHandlers;

public class AppTaskListHandler : IRequestHandler<AppTaskListRequest, PagedResult<AppTaskListDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AppTaskListHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PagedResult<AppTaskListDto>> Handle(AppTaskListRequest request, CancellationToken cancellationToken)
    {
        var appTasks = await _unitOfWork.AppTask.GetAllAsync(request.ActivePage);
        var appTaskLists = _mapper.Map<List<AppTaskListDto>>(appTasks);

        return new PagedResult<AppTaskListDto>(appTaskLists, request.ActivePage, appTasks.PageSize, appTasks.TotalPages);
    }
}
