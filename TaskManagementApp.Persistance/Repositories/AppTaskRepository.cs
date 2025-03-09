namespace TaskManagementApp.Persistance.Repositories;

public class AppTaskRepository : IAppTaskRepository
{
    private readonly TaskManagementContext _context;

    public AppTaskRepository(TaskManagementContext context)
    {
        _context = context;
    }

    public async Task<PagedData<AppTask>> GetAllAsync(int activePage, int pageSize = 10)
    {
        return await _context.AppTasks
            .Include(x => x.Category)
            .Include(x => x.AppUser)
            .Include(x => x.TaskReports)
            .AsNoTracking()
            .ToPagedAsync(activePage, pageSize);
    }
}
