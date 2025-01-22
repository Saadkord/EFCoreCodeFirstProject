using EFCore.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;


namespace EFCore.Data.Configuration
{
    public class ConfigurationSection : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.SectionName).HasColumnType("VARCHAR").HasMaxLength(100).IsRequired();

            builder.OwnsOne(x => x.TimeSlot, tm =>
            {
                tm.Property(p => p.StartTime).HasColumnType("time").HasColumnName("StartTime");
                tm.Property(p => p.EndTime).HasColumnType("time").HasColumnName("EndTime");

            });

            builder.HasOne(x => x.Course).WithMany(x => x.Sections)
                .HasForeignKey(x => x.CourseId).IsRequired(true);

            builder.HasOne(x => x.Instractor).WithMany(x => x.Sections)
                .HasForeignKey(x => x.InstractorId).IsRequired(false);

            builder.HasMany(x => x.Students).WithMany(x => x.Sections).UsingEntity<SectionStudent>();

            builder.HasOne(x => x.Secheduals).WithMany(x => x.Sections).HasForeignKey(x => x.ScheduleId).IsRequired(true);
        }
    }
}
