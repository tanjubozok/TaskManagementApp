namespace TaskManagementApp.Application.Requests;

public record AppTaskListRequest() : IRequest<List<AppTaskListDto>>;