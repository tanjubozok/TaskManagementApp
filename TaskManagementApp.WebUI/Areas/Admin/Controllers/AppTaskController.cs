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
    public async Task<IActionResult> List()
    {
        var result = await _mediator.Send(new AppTaskListRequest());
        return View(result.Data);
    }
}
