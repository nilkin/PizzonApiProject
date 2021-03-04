using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
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
                Property(c => c.Name).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Text).
                HasColumnType("ntext").
                IsRequired();
            builder.
                Property(c => c.Author).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Tag).
                HasMaxLength(100).
                IsRequired();
            //builder.
            //    Property(c => c.IsNew).
            //    HasDefaultValue(false);

            builder.
                ToTable("Blogs");

        }
    }
}
