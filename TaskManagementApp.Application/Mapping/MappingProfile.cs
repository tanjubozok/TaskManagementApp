namespace TaskManagementApp.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryListDto>().ReverseMap();
        CreateMap<Category, CategoryGetByIdRequest>().ReverseMap();
        CreateMap<Category, CategoryUpdateRequest>().ReverseMap();
        CreateMap<Category, CategoryCreateRequst>().ReverseMap();
    }
}