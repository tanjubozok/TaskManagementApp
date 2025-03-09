namespace TaskManagementApp.Persistance.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly TaskManagementContext _context;
    private ICategoryRepository _categoryRepository;
    private IUserRepository _userRepository;
    private IAppTaskRepository _appTask;

    public UnitOfWork(TaskManagementContext context)
        => _context = context;

    public ICategoryRepository Category
        => _categoryRepository ??= new CategoryRepository(_context);

    public IUserRepository User
        => _userRepository ??= new UserRepository(_context);

    public IAppTaskRepository AppTask
        => _appTask ??= new AppTaskRepository(_context);

    public async ValueTask DisposeAsync()
        => await _context.DisposeAsync();

    public async Task<int> SaveChangesAsync()
        => await _context.SaveChangesAsync();
}
