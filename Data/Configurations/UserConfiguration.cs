using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
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
                Property(c => c.PhotoUrl).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Email).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Password).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Phone).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Token).
                HasMaxLength(100);

            builder.
                ToTable("Users");

        }
    }
}
