namespace TaskManagementApp.Persistance.Repositories;

public class UserRepository : IUserRepository
{
    private readonly TaskManagementContext _context;

    public UserRepository(TaskManagementContext context)
    {
        _context = context;
    }

    public async Task<int> CreateUserAsync(AppUser user)
    {
        await _context.AppUsers.AddAsync(user);
        return await _context.SaveChangesAsync();
    }

    public async Task<AppUser?> GetByFilterAsync(Expression<Func<AppUser, bool>> filter, bool asNoTracking = true)
    {
        if (asNoTracking)
            return await _context.AppUsers.AsNoTracking().SingleOrDefaultAsync(filter);
        return await _context.AppUsers.SingleOrDefaultAsync(filter);
    }
}
