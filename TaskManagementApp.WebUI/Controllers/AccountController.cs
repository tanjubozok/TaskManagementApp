using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskManagementApp.Application.Requests;

namespace TaskManagementApp.WebUI.Controllers;

public class AccountController : Controller
{
    private readonly IMediator _mediator;

    public AccountController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginRequst requst)
    {
        var result = await _mediator.Send(requst);
        if (result.IsSuccess)
        {

        }

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
