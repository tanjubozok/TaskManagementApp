namespace TaskManagementApp.Application.Extensions;

public static class MappingExtensions
{
    public static AppUser ToAppUser(this RegisterRequest request)
    {
        return new AppUser
        {
            AppRoleId = (int)RoleTypes.Member,
            Name = request.Name,
            Surname = request.Surname,
            Username = request.Username,
            Password = request.Password
        };
    }
}