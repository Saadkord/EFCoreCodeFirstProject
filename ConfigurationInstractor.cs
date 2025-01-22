using EFCore.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;


namespace EFCore.Data.Configuration
{
    public class ConfigurationInstractor : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.FName).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();
            builder.Property(x => x.LName).HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();

            builder.HasOne(x => x.Office).WithOne(x => x.Insttractor)
                .HasForeignKey<Instructor>(x => x.OfficeId).IsRequired(false);
            builder.ToTable("Instructors");
        }
    }

}
