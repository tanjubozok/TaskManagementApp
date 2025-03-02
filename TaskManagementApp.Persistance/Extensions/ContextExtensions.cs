namespace TaskManagementApp.Persistance.Extensions;

public static class ContextExtensions
{
    public static async Task<PagedData<T>> ToPagedAsync<T>(this IQueryable<T> query, int page, int pageSize)
        where T : class
    {
        if (page < 1) throw new ArgumentException("Page number must be at least 1.");
        if (pageSize <= 0) throw new ArgumentException("Page size must be greater than 0.");

        var totalCount = await query.CountAsync();
        var list = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

        return new PagedData<T>(list, totalCount, page, pageSize);
    }
}