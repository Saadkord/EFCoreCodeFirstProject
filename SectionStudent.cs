namespace EFCore.Data.Entites
{
    public class SectionStudent
    {
        public int SectionId { get; set; }
        public int StudentId { get; set; }
        public Section Section { get; set; }
        public Student Student { get; set; }
    }
}
