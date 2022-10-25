namespace EclassBackend.Models
{
    public class LabStudents
    {
        public int StudentID { get; set; }
        public int LabId { get; set; }
        public Student Student { get; set; }
        public Lab Lab{ get; set; }
    }
}
