namespace TaskManagementApp.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryListDto>();
        CreateMap<CategoryUpdateRequest, Category>();
        CreateMap<CategoryCreateRequst, Category>();
    }
}
