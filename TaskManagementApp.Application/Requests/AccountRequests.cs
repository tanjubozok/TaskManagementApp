using MediatR;
using TaskManagementApp.Application.Dtos;

namespace TaskManagementApp.Application.Requests;

public record LoginRequst(string? Username, string? Password, bool RememberMe) : IRequest<Result<LoginResponseDto?>>;
