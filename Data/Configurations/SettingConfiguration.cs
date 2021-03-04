using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class SettingConfiguration : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.
                HasKey(c => c.Id);
            builder.
                Property(c => c.Id).
                ValueGeneratedOnAdd();
            builder.
                Property(c => c.OpenTime).
                HasColumnType("date").
                IsRequired();
            builder.
                Property(c => c.CloseTime).
                HasColumnType("date").
                IsRequired();
            builder.
                Property(c => c.BookInfo).
                HasMaxLength(500).
                IsRequired();
            builder.
                Property(c => c.PhoneNumber).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Address).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Email).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.ContactInfo).
                HasMaxLength(500);    
            builder.
                Property(c => c.Longitude).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Longitude).
                HasMaxLength(100).
                IsRequired();

            builder.
                ToTable("Settings");

        }
    }
}
