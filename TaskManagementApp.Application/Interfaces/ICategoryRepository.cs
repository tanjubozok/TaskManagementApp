namespace TaskManagementApp.Application.Interfaces;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllsync();

    Task CreateAsync(Category category);

    Task<Category?> GetByFilterNoTrackingAsync(Expression<Func<Category, bool>> filter);
    Task<Category?> GetByFilterAsync(Expression<Func<Category, bool>> filter);

    void Delete(Category category);

    void Update(Category category);
}
