using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class BreadcrumbConfiguration : IEntityTypeConfiguration<Breadcrumb>
    {
        public void Configure(EntityTypeBuilder<Breadcrumb> builder)
        {
            builder.
                HasKey(c => c.Id);
            builder.
                Property(c => c.Id).
                ValueGeneratedOnAdd();
            builder.
                Property(c => c.PhotoUrl).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Path).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Link).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.IsMenu).
                HasDefaultValue(false);
            builder.
                Property(c => c.IsBlog).
                HasDefaultValue(false);
            builder.
                Property(c => c.IsReservation).
                HasDefaultValue(false);
            builder.
                Property(c => c.IsAboutUs).
                HasDefaultValue(false);
            builder.
                Property(c => c.IsContactUs).
                HasDefaultValue(false);
            builder.
                ToTable("Breadcrumbs");


        }
    }
}
