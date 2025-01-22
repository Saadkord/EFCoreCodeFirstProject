using System;
using System.Collections.Generic;

namespace EFCore.Data.Entites
{
    public class Section
    {
        public int Id { get; set; }
        public string? SectionName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int? InstractorId { get; set; }
        public Instructor? Instractor { get; set; }
        public int ScheduleId { get; set; }
        public Sechedual Secheduals { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public ICollection<SectionStudent> SectionStudents { get; set; } = new List<SectionStudent>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
    public class TimeSlot
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public override string ToString()
        {
            return $"{StartTime}-{EndTime}";
        }
    }
}
