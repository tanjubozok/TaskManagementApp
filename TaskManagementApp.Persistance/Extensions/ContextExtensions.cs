namespace TaskManagementApp.Persistance.Extensions;

public static class ContextExtensions
{
    public static async Task<PagedData<T>> ToPagedAsync<T>(this IQueryable<T> query, int activePage, int pageSize = 10)
        where T : class, new()
    {
        var totalRecords = await query.CountAsync();
        var data = await query.Skip((activePage - 1) * pageSize).Take(pageSize).ToListAsync();

        return new PagedData<T>(data, activePage, totalRecords, pageSize);
    }
}