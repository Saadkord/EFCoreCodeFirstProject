using EFCore.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EFCore.Data.Configuration
{
    public class ConfigurationSchedule : IEntityTypeConfiguration<Sechedual>
    {
        public void Configure(EntityTypeBuilder<Sechedual> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.Title).HasConversion(x => x.ToString(), x => (ScheduleEnum)Enum.Parse(typeof(ScheduleEnum), x));
            builder.ToTable("Schedules");

        }
    }
}
