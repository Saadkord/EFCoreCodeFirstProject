using EFCore.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;


namespace EFCore.Data.Configuration
{
    public class ConfigurationCource : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.CourseName).HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Price).HasPrecision(10, 2);
            builder.ToTable("Cources");


        }
    }
}
