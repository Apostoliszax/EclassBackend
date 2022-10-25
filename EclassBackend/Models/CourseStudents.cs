namespace EclassBackend.Models
{
    public class CourseStudents
    {
        public int StudentID { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
