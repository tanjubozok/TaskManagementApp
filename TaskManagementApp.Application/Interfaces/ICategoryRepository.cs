namespace TaskManagementApp.Application.Interfaces;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllsync();

    Task<int> CreateAsync(Category category);
}
