using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.
                HasKey(c => c.Id);
            builder.
                Property(c => c.Id).
                ValueGeneratedOnAdd();
            builder.
                Property(c => c.Status).
                HasDefaultValue(false);
            builder.
                Property(c => c.Quantity).
                IsRequired();
            builder.
                Property(c => c.Price).
                HasColumnType("money").
                IsRequired();

            builder.
                ToTable("Stocks");

        }
    }
}
