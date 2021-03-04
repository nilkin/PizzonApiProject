using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.
                HasKey(c => c.Id);
            builder.
                Property(c => c.Id).
                ValueGeneratedOnAdd();
            builder.
                Property(c => c.Phone).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Email).
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
                ToTable("Contacts");

        }
    }
}
