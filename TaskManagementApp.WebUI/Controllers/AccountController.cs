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
        return View(new LoginRequst("", "", false));
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginRequst request)
    {
        var result = await _mediator.Send(request);
        if (result.IsSuccess && result.Data is not null)
        {
            await SetAuthCookie(result.Data, request.RememberMe);

            if (result.Data.Role == Application.Enums.RoleTypes.Admin)
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            else
                return RedirectToAction("Index", "Home", new { area = "Member" });
        }
        else
        {
            if (result.Errors is not null && result.Errors.Count > 0)
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
            return View(request);
        }
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var result = await _mediator.Send(request);
        if (result.IsSuccess)
        {
            return RedirectToAction("Login", "Account");
        }
        else
        {
            if (result.Errors is not null && result.Errors.Count > 0)
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
            return View(request);
        }
    }

    public IActionResult ForgotPassword()
    {
        return View();
    }

    public async Task<IActionResult> LogOut()
    {
        // Clear the existing external cookie
        await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);

        return RedirectToAction("Login");
    }

    private async Task SetAuthCookie(LoginResponseDto dto, bool rememberMe)
    {
        List<Claim> claims = new()
        {
            new("Name", dto.Name),
            new("Surname", dto.Surname),
            new(ClaimTypes.Role, dto.Role.ToString())
        };

        var claimsIdentity = new ClaimsIdentity(
            claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var authProperties = new AuthenticationProperties
        {
            //AllowRefresh = <bool>,
            // Refreshing the authentication session should be allowed.

            ExpiresUtc = DateTimeOffset.UtcNow.AddDays(30),
            // The time at which the authentication ticket expires.
            // A value set here overrides the ExpireTimeSpan option of CookieAuthenticationOptions set with AddCookie.

            IsPersistent = rememberMe,
            // Whether the authentication session is persisted across  multiple requests.
            // When used with cookies, controls whether the cookie's lifetime is absolute (matching the lifetime of the authentication ticket) or session-based.

            //IssuedUtc = <DateTimeOffset>,
            // The time at which the authentication ticket was issued.

            //RedirectUri = <string>
            // The full path or absolute URI to be used as an http 
            // redirect response value.
        };

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity),
            authProperties);
    }
}
