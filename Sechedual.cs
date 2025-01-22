using System.Collections.Generic;

namespace EFCore.Data.Entites
{
    public class Sechedual
    {
        public int Id { get; set; }
        public ScheduleEnum Title { get; set; }
        public bool SUN { get; set; }
        public bool MON { get; set; }
        public bool TUE { get; set; }
        public bool WED { get; set; }
        public bool THE { get; set; }
        public bool FRI { get; set; }
        public bool SAT { get; set; }
        public Office? Office { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }

    public enum ScheduleEnum
    {
        diely,
        weekend
    }
}
