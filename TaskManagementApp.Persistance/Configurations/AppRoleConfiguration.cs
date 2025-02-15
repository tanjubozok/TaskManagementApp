using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagementApp.Domain.Entities;

namespace TaskManagementApp.Persistance.Configurations;

public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
{
    public void Configure(EntityTypeBuilder<AppRole> builder)
    {
        builder.ToTable("AppRoles");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.Property(x => x.Definition).IsRequired(true);
        builder.Property(x => x.Definition).HasMaxLength(128);

        builder.HasMany(x => x.AppUsers).WithOne(x => x.AppRole).HasForeignKey(x => x.AppRoleId);
    }
}
