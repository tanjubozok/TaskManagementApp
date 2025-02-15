namespace TaskManagementApp.Domain.Entities;

public class AppUser : BaseEntity
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;

    public int AppRoleId { get; set; }
    public AppRole? AppRole { get; set; }

    public List<AppTask>? AppTasks { get; set; }
    public List<Notification>? Notifications { get; set; }
}
