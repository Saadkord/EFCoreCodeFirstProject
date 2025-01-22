using EFCore.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;


namespace EFCore.Data.Configuration
{
    public class ConfigurationStudent : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.FName).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();
            builder.Property(x => x.LName).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();

            builder.HasMany(x => x.Sections).WithMany(x => x.Students).UsingEntity<SectionStudent>();
            builder.ToTable("Students");
        }
    }
}
