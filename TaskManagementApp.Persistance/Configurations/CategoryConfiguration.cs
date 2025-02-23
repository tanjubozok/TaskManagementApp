using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskManagementApp.Persistance.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();

        builder.Property(c => c.Definition).IsRequired(true);
        builder.Property(c => c.Definition).HasMaxLength(128);

        builder.HasMany(c => c.AppTasks).WithOne(t => t.Category).HasForeignKey(t => t.CategoryId);
    }
}