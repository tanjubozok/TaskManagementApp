using Microsoft.EntityFrameworkCore;
using TaskManagementApp.Domain.Entities;

namespace TaskManagementApp.Persistance.Context;

public class TaskManagementContext : DbContext
{
    public TaskManagementContext(DbContextOptions<TaskManagementContext> options)
        : base(options)
    {
    }

    public DbSet<AppRole> AppRoles { get; set; }
    public DbSet<AppTask> AppTasks { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<TaskReport> TaskReports { get; set; }
}
