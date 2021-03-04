using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.
                HasKey(c => c.Id);
            builder.
                Property(c => c.Id).
                ValueGeneratedOnAdd();
            builder.
                Property(c => c.Fullname).
                HasMaxLength(100).
                IsRequired(); 
            builder.
                Property(c => c.Subject).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Message).
                HasColumnType("ntext").
                IsRequired();
            builder.
                Property(c => c.PhotoUrl).
                HasMaxLength(100).
                IsRequired(); 
            builder.
                Property(c => c.Email).
                HasMaxLength(100).
                IsRequired();
            builder.
                HasOne(c => c.Product).
                WithMany(c => c.Reviews).
                HasForeignKey(c => c.ProductId).
                OnDelete(DeleteBehavior.Cascade);
            builder.
                ToTable("Reviews");

        }
    }
}
