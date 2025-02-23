namespace TaskManagementApp.Application.Requests;

public record LoginRequst
    (string? Username, string? Password, bool RememberMe)
    : IRequest<Result<LoginResponseDto?>>;

public record RegisterRequest
    (string? Username, string? Password, string? RePassword, string? Name, string? Surname)
    : IRequest<Result<NoData>>;

