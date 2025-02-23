using TaskManagementApp.Application.Enums;

namespace TaskManagementApp.Application.Dtos
{
    public record LoginResponseDto(string Name, string Surname, RoleTypes Role);
}
