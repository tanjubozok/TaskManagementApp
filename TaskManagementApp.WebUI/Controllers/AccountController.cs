﻿using Microsoft.AspNetCore.Mvc;

namespace TaskManagementApp.WebUI.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
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
