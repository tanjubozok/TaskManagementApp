namespace TaskManagementApp.Application.Interfaces;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllsync();

    Task<int> CreateAsync(Category category);

    Task<Category?> GetByFilterNoTrackingAsync(Expression<Func<Category, bool>> filter);
    Task<Category?> GetByFilterAsync(Expression<Func<Category, bool>> filter);

    Task DeleteAsync(Category category);

    Task<int> UpdateAsync(Category category);
}
