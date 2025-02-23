using MediatR;
using TaskManagementApp.Application.Dtos;
using TaskManagementApp.Application.Extensions;
using TaskManagementApp.Application.Interfaces;
using TaskManagementApp.Application.Requests;
using TaskManagementApp.Application.Validators;

namespace TaskManagementApp.Application.Handlers;

public class LoginRequestHandler : IRequestHandler<LoginRequst, Result<LoginResponseDto?>>
{
    private readonly IUserRepository _user;

    public LoginRequestHandler(IUserRepository user)
    {
        _user = user;
    }

    public async Task<Result<LoginResponseDto?>> Handle(LoginRequst request, CancellationToken cancellationToken)
    {
        var validator = new LoginRequestValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.IsValid)
        {
            var user = await _user.GetByFilterAsync(x => x.Username == request.Username && x.Password == request.Password);
            if (user is not null)
                return new Result<LoginResponseDto?>(new LoginResponseDto(user.Name, user.Surname, user.AppRoleId), true, null, null);
            else
                return new Result<LoginResponseDto?>(null, false, "Kullanıcı adı veya şifre hatalıdır", null);
        }
        else
        {
            var errorList = validationResult.Errors.ToMap();

            return new Result<LoginResponseDto?>(null, false, "ValidationError", errorList);
        }
    }
}
