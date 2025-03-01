namespace TaskManagementApp.Persistance.Repositories;

public class AppTaskRepository : IAppTaskRepository
{
    private readonly TaskManagementContext _context;

    public AppTaskRepository(TaskManagementContext context)
    {
        _context = context;
    }

    public async Task<List<AppTask>> GetAllAsync()
    {
        return await _context.AppTasks
            .Include(x => x.Category)
            .Include(x => x.AppUser)
            .Include(x => x.TaskReports)
            .AsNoTracking()
            .ToListAsync();
    }
}
