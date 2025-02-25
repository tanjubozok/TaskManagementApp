namespace TaskManagementApp.Application.Interfaces;

public interface IUnitOfWork : IAsyncDisposable
{
    ICategoryRepository Category { get; }
    IUserRepository User { get; }

    Task<int> SaveChangesAsync();
}
