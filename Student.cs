using System.Collections.Generic;

namespace EFCore.Data.Entites
{
    public class Student
    {
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public ICollection<Section> Sections { get; set; } = new List<Section>();
        public ICollection<SectionStudent> SectionStudents { get; set; } = new List<SectionStudent>();


    }
}
