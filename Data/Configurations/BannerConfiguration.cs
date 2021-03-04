using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class BannerConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
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
                Property(c => c.Header).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Body).
                HasMaxLength(200).
                IsRequired();
            builder.
                Property(c => c.IsBanner).
                HasDefaultValue(false);
            builder.
                Property(c => c.IsService).
                HasDefaultValue(false);

            builder.
                ToTable("Banners");

        }
    }
}
