namespace TaskManagementApp.Persistance.Configurations;

public class AppTaskConfiguration : IEntityTypeConfiguration<AppTask>
{
    public void Configure(EntityTypeBuilder<AppTask> builder)
    {
        builder.ToTable("AppTasks");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Title).IsRequired(true);
        builder.Property(x => x.Title).HasMaxLength(256);

        builder.Property(x => x.Description).IsRequired(true);
        builder.Property(x => x.Description).HasMaxLength(2048);

        builder.Property(x => x.AppUserId).IsRequired(true);

        builder.Property(x => x.CategoryId).IsRequired(true);

        builder.HasMany(x => x.TaskReports).WithOne(x => x.AppTask).HasForeignKey(x => x.AppTaskId);
    }
}
