namespace TaskManagementApp.Domain.Entities;

public class AppRole : BaseEntity
{
    public string Definition { get; set; } = null!;

    public List<AppUser>? AppUsers { get; set; }
}
