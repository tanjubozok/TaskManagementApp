namespace TaskManagementApp.Domain.Entities;

public class Category : BaseEntity
{
    public string Definition { get; set; } = null!;

    public List<AppTask>? AppTasks { get; set; }
}
