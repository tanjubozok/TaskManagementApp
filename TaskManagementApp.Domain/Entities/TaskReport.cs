namespace TaskManagementApp.Domain.Entities;

public class TaskReport : BaseEntity
{
    public string Defination { get; set; } = null!;
    public string Description { get; set; } = null!;

    public int AppTaskId { get; set; }
    public AppTask? AppTask { get; set; }
}
