﻿namespace TaskManagementApp.Application.Requests;

public record AppTaskListRequest : PagedRequest, IRequest<PagedResult<AppTaskListDto>>
{
    public AppTaskListRequest(int ActivePage) : base(ActivePage)
    {
    }
}
