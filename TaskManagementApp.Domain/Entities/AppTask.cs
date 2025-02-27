namespace TaskManagementApp.Domain.Entities;

public class AppTask : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool State { get; set; }

    public int? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    public List<TaskReport>? TaskReports { get; set; }
}
