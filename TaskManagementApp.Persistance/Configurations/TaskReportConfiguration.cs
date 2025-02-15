using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementApp.Domain.Entities;

namespace TaskManagementApp.Persistance.Configurations;

public class TaskReportConfiguration : IEntityTypeConfiguration<TaskReport>
{
    public void Configure(EntityTypeBuilder<TaskReport> builder)
    {
        builder.ToTable("TaskReports");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Defination).IsRequired(true);
        builder.Property(x => x.Defination).HasMaxLength(128);

        builder.Property(x => x.Description).IsRequired(true);
        builder.Property(x => x.Description).HasMaxLength(2048);

        builder.Property(x => x.AppTaskId).IsRequired(true);
    }
}
