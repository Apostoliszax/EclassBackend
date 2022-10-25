namespace EclassBackend.Models
{
    public class Course
    {
        public int CourseId{ get; set; }
        public string Name{ get; set; }
        public int Hours{ get; set; }
        public string Classroom{ get; set; }
        public int ECTS { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Professor> Professors { get; set; }
        public Lab? Lab { get; set; }
    }
}