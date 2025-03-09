namespace TaskManagementApp.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class AppTaskController : Controller
{
    private readonly IMediator _mediator;

    public AppTaskController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> List(int activePage)
    {
        var result = await _mediator.Send(new AppTaskListRequest(activePage));
        return View(result.Data);
    }
}
