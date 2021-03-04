using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
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
                Property(c => c.Subject).
                HasMaxLength(100).
                IsRequired();
            builder.
                Property(c => c.Message).
                HasColumnType("ntext").
                IsRequired();
            builder.
                HasOne(c => c.Blog).
                WithMany(c => c.Comments).
                HasForeignKey(c => c.BlogId).
                OnDelete(DeleteBehavior.Cascade);

            builder.
                ToTable("Comments");

        }
    }
}
