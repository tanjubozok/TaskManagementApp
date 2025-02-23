using MediatR;
using TaskManagementApp.Application.Dtos;
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
            return new Result<LoginResponseDto?>(new LoginResponseDto("", "", 1), true, null, null);
        }
        else
        {
            var errorList = new List<ValidationError>();
            var erors = validationResult.Errors.ToList();
            foreach (var error in erors)
            {
                errorList.Add(new ValidationError(error.PropertyName, error.ErrorMessage));
            }

            return new Result<LoginResponseDto?>(null, false, "ValidationError", errorList);
        }
    }
}
