using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManagementApp.Persistance.Configurations;

public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.ToTable("Notifications");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Description).IsRequired(true);
        builder.Property(x => x.Description).HasMaxLength(512);

        builder.Property(x => x.State).IsRequired(true);

        builder.Property(x => x.AppUserId).IsRequired(true);
    }
}