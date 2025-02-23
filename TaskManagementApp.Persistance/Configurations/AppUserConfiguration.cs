using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManagementApp.Persistance.Configurations;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.ToTable("AppUsers");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Username).IsRequired(true);
        builder.Property(x => x.Username).HasMaxLength(64);
        builder.HasIndex(x => x.Username).IsUnique(true);

        builder.Property(x => x.Password).IsRequired(true);
        builder.Property(x => x.Password).HasMaxLength(64);

        builder.Property(x => x.Name).IsRequired(true);
        builder.Property(x => x.Name).HasMaxLength(64);

        builder.Property(x => x.Surname).IsRequired(true);
        builder.Property(x => x.Surname).HasMaxLength(64);

        builder.HasMany(x => x.AppTasks).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
        builder.HasMany(x => x.Notifications).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
    }
}
