namespace TaskManagementApp.Application.Requests;

public record CategoryListRequest()
    : IRequest<Result<List<CategoryListDto>>>;

public record CategoryGetByIdRequest
    (int Id)
    : IRequest<Result<CategoryListDto>>;

public record CategoryUpdateRequest
    (int Id, string? Definition)
    : IRequest<Result<NoData>>;

public record CategoryCreateRequst
    (string? Definition)
    : IRequest<Result<NoData>>;

public record CategoryDeleteRequest
    (int Id)
    : IRequest<Result<NoData>>;