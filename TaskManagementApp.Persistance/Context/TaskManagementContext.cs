using Microsoft.EntityFrameworkCore;
using TaskManagementApp.Domain.Entities;
using TaskManagementApp.Persistance.Configurations;

namespace TaskManagementApp.Persistance.Context;

public class TaskManagementContext : DbContext
{
    public TaskManagementContext(DbContextOptions<TaskManagementContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
        modelBuilder.ApplyConfiguration(new AppTaskConfiguration());
        modelBuilder.ApplyConfiguration(new AppUserConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new NotificationConfiguration());
        modelBuilder.ApplyConfiguration(new TaskReportConfiguration());

        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagementContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<AppRole> AppRoles { get; set; }
    public DbSet<AppTask> AppTasks { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<TaskReport> TaskReports { get; set; }
}
