namespace TaskManagementApp.Application.Dtos;

public record Result<T>(T Data, bool IsSuccess, string? ErrorMessage, List<ValidationError>? Errors);
public record ValidationError(string PropertyName, string ErrorMessage);
public record NoData();

public record PagedResult<T>(List<T> Data, int ActivePage, int PageSize, int TotalPage);

public record PagedData<T>
    where T : class, new()
{
    public PagedData(List<T> data, int activePage, int totalRecords, int pageSize)
    {
        Data = data;
        ActivePage = activePage;
        TotalRecords = totalRecords;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
    }
    public List<T> Data { get; set; }
    public int ActivePage { get; set; }
    public int PageSize { get; set; }
    public int TotalRecords { get; set; }
    public int TotalPages { get; set; }
}