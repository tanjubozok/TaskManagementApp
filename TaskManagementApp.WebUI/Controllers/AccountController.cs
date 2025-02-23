using Microsoft.AspNetCore.Mvc;
using TaskManagementApp.Application.Dtos;

namespace TaskManagementApp.WebUI.Controllers;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginResponseDto dto)
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult ForgotPassword()
    {
        return View();
    }

    public IActionResult LogOut()
    {
        return View();
    }
}
