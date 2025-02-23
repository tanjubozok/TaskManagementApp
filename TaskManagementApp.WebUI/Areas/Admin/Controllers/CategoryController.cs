namespace TaskManagementApp.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class CategoryController : Controller
{
    private readonly IMediator _mediator;

    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IActionResult> List()
    {
        var result = await _mediator.Send(new CategoryListRequest());
        return View(result.Data);
    }

    public IActionResult Create()
    {
        return View();
    }
}
