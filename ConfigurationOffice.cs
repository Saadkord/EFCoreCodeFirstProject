using EFCore.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;


namespace EFCore.Data.Configuration
{
    public class ConfigurationOffice : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.OfficeName).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            builder.Property(x => x.OfficeLocation).HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            builder.ToTable("Offices");
        }      
    }
}
