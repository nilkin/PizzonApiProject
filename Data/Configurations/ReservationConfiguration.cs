using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.
                HasKey(c => c.Id);
            builder.
                Property(c => c.Id).
                ValueGeneratedOnAdd();
            builder.
                Property(c => c.BookDate).
                HasColumnType("date").
                IsRequired();
            builder.
                Property(c => c.BookTime).
                HasColumnType("date");
            builder.
                Property(c => c.PeopleCount).
                HasMaxLength(10).
                IsRequired();
            builder.
                Property(c => c.PhoneNumber).
                HasMaxLength(18);
            builder.
                Property(c => c.Fullname).
                HasMaxLength(50).
                IsRequired();
            builder.
                Property(c => c.Email).
                HasMaxLength(60).
                IsRequired();
            builder.
                Property(c => c.Comment).
                HasMaxLength(600).
                HasColumnType("ntext");
            builder.
                ToTable("Reservations");

        }
    }
}
