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

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var result = await _mediator.Send(new CategoryListRequest());
        return View(result.Data);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CategoryCreateRequst requst)
    {
        var result = await _mediator.Send(requst);
        if (result.IsSuccess)
        {
            return RedirectToAction("List");
        }
        else
        {
            if (result.Errors?.Count > 0)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            else
            {
                ModelState.AddModelError("", result.ErrorMessage ?? "Bilinmeyen bir hata oluştu");
            }
            return View(requst);
        }
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new CategoryDeleteRequest(id));
        return RedirectToAction("List");
    }
}
