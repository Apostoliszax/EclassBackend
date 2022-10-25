namespace EclassBackend.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int GPA { get; set; }
        public bool hasThesis { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
