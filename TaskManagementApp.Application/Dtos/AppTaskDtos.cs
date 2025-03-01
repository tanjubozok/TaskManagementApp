namespace TaskManagementApp.Application.Dtos;

public record AppTaskListDto(int Id, string Title, string Description, string CategorDefinition, bool State);
