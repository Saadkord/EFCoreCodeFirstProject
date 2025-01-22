namespace EFCore.Data.Entites
{
    public class Office
    {
        public int Id { get; set; }
        public string? OfficeName { get; set; }
        public string? OfficeLocation { get; set; }
        public Instructor? Insttractor { get; set; }

    }
}
