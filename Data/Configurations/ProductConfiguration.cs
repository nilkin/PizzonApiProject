using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.
                HasKey(c => c.Id);
            builder.
                Property(c => c.Id).
                ValueGeneratedOnAdd();
            builder.
                Property(c => c.Name).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Detail).
                HasMaxLength(500).
                IsRequired();
            builder.
                Property(c => c.Description).
                HasColumnType("ntext").
                IsRequired();
            builder.
                Property(c => c.ProductType).
                HasMaxLength(200).
                IsRequired();
            builder.
                Property(c => c.PhotoUrl).
                HasMaxLength(200).
                IsRequired();
            builder.
                Property(c => c.IsPromo).
                HasDefaultValue(false);
            builder.
                HasOne(c => c.Stock).
                WithMany(c => c.Products).
                HasForeignKey(c => c.StockId).
                OnDelete(DeleteBehavior.Cascade);
            builder.
                HasOne(c => c.Category).
                WithMany(c => c.Products).
                HasForeignKey(c => c.CategoryId).
                OnDelete(DeleteBehavior.Cascade);
            builder.
                ToTable("Products");

        }
    }
}
