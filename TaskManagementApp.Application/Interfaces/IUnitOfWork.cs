namespace TaskManagementApp.Application.Interfaces;

public interface IUnitOfWork : IAsyncDisposable
{
    ICategoryRepository Category { get; }
    IUserRepository User { get; }
    IAppTaskRepository AppTask { get; }

    Task<int> SaveChangesAsync();
}
