namespace EclassBackend.Models
{
    public class Lab
    {
        public int LabId { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public string Classroom { get; set; }
        public ICollection<Student>? Students { get; set; }
        public ICollection<Professor> Professors { get; set; }
    }
}