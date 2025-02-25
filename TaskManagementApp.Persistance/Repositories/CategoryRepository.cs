namespace TaskManagementApp.Persistance.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly TaskManagementContext _context;

    public CategoryRepository(TaskManagementContext context)
    {
        _context = context;
    }

    public async Task<int> CreateAsync(Category category)
    {
        await _context.Categories.AddAsync(category);
        return await _context.SaveChangesAsync();
    }

    public async Task<List<Category>> GetAllsync()
    {
        return await _context.Categories.AsNoTracking().ToListAsync();
    }
}
