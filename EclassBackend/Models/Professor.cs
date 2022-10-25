namespace EclassBackend.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Course>? Courses { get; set; }
        public ICollection<Lab>? Labs{ get; set; }
    }
}