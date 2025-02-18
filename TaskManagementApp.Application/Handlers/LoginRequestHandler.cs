using MediatR;
using TaskManagementApp.Application.Dtos;
using TaskManagementApp.Application.Interfaces;
using TaskManagementApp.Application.Requests;

namespace TaskManagementApp.Application.Handlers;

public class LoginRequestHandler : IRequestHandler<LoginRequst, Result<LoginResponseDto>>
{
    private readonly IUserRepository _userRepository;

    public LoginRequestHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<Result<LoginResponseDto>> Handle(LoginRequst request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
