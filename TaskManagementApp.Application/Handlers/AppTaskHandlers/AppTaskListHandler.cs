namespace TaskManagementApp.Application.Handlers.AppTaskHandlers;

public class AppTaskListHandler : IRequestHandler<AppTaskListRequest, Result<List<AppTaskListDto>>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AppTaskListHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<Result<List<AppTaskListDto>>> Handle(AppTaskListRequest request, CancellationToken cancellationToken)
    {
        var appTasks = await _unitOfWork.AppTask.GetAllAsync();
        var appTaskLists = _mapper.Map<List<AppTaskListDto>>(appTasks);
        if (appTaskLists.Count == 0)
            return new Result<List<AppTaskListDto>>(appTaskLists, false, "No data found", null);

        return new Result<List<AppTaskListDto>>(appTaskLists, true, null, null);
    }
}
