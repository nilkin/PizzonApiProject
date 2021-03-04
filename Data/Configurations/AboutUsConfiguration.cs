using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class AboutUsConfiguration : IEntityTypeConfiguration<AboutUs>
    {
        public void Configure(EntityTypeBuilder<AboutUs> builder)
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
                Property(c => c.Description).
                HasMaxLength(500);
            builder.
                Property(c => c.IsHome).
                HasDefaultValue(false);
            builder.
                Property(c => c.IsAbout).
                HasDefaultValue(false);
            builder.
                Property(c => c.IsStory).
                HasDefaultValue(false);
            builder.
                Property(c => c.IsExperience).
                HasDefaultValue(false);

            builder.
                ToTable("Abouts");


        }
    }
}
