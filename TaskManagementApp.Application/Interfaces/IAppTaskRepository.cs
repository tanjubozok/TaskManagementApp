namespace TaskManagementApp.Application.Interfaces;

public interface IAppTaskRepository
{
    Task<List<AppTask>> GetAllAsync();
}
