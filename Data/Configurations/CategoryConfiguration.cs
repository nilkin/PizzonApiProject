﻿using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class Categoryfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.
                HasKey(c => c.Id);
            builder.
                Property(c => c.Id).
                ValueGeneratedOnAdd();
            builder.
                Property(c => c.Name).
                HasMaxLength(50).
                IsRequired();
            builder.
                ToTable("Categories");
        }
    }
}
