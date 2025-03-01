namespace TaskManagementApp.Application.Requests;

public record AppTaskListRequest() : IRequest<Result<List<AppTaskListDto>>>;