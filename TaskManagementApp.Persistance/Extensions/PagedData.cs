namespace TaskManagementApp.Persistance.Extensions;

public record PagedData<T>(List<T> Data, int TotalCount, int Page, int PageSize)
    where T : class
{
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
}