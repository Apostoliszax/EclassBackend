namespace EclassBackend.Models
{
    public class CourseProfessors
    {
        public int ProfessorID { get; set; }
        public int CourseId { get; set; }
        public Professor Professor { get; set; }
        public Course Course { get; set; }

    }
}
