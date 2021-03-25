using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.
                HasKey(c => c.Id);
            builder.
                Property(c => c.Id).
                ValueGeneratedOnAdd();
            builder.
                Property(c => c.Fullname).
                HasMaxLength(50).
                IsRequired();
            builder.
                Property(c => c.PhotoUrl).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Position).
                HasMaxLength(50).
                IsRequired();
            builder.
                Property(c => c.Thought).
                HasMaxLength(600).
                HasColumnType("ntext").
                IsRequired();

            builder.
                ToTable("Testimonials");

        }
    }
}
