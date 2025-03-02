namespace TaskManagementApp.Application.Dtos;

public record Result<T>(T Data, bool IsSuccess, string? ErrorMessage, List<ValidationError>? Errors);
public record ValidationError(string PropertyName, string ErrorMessage);
public record NoData();

public record PagedResult<T>(List<T> Data, int TotalCount, int Page, int PageSize)
    where T : class
{
    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
}