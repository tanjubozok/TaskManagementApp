using Microsoft.AspNetCore.Mvc;
using TaskManagementApp.Application.Requests;

namespace TaskManagementApp.WebUI.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginDto dto)
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult LogOut()
    {
        return View();
    }
}
