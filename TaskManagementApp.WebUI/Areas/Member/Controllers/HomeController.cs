namespace TaskManagementApp.WebUI.Areas.Member.Controllers;

[Area("Member")]
[Authorize]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
