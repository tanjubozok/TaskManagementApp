namespace TaskManagementApp.Persistance.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly TaskManagementContext _context;

    public CategoryRepository(TaskManagementContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Category category)
        => await _context.Categories.AddAsync(category);

    public void Delete(Category category)
        => _context.Categories.Remove(category);

    public async Task<List<Category>> GetAllsync()
        => await _context.Categories.AsNoTracking().ToListAsync();

    public async Task<Category?> GetByFilterAsync(Expression<Func<Category, bool>> filter)
        => await _context.Categories.SingleOrDefaultAsync(filter);

    public async Task<Category?> GetByFilterNoTrackingAsync(Expression<Func<Category, bool>> filter)
        => await _context.Categories.AsNoTracking().SingleOrDefaultAsync(filter);

    public void Update(Category category)
        => _context.Categories.Update(category);
}
