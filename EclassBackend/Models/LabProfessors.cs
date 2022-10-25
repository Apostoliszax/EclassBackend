namespace EclassBackend.Models
{
    public class LabProfessors
    {
        public int ProfessorID { get; set; }
        public int LabId { get; set; }
        public Professor Professor { get; set; }
        public Lab Lab { get; set; }
    }
}
