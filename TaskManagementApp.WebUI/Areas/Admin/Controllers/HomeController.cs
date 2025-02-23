using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagementApp.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
