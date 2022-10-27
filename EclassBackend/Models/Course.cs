using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EclassBackend.Models
{
    public class Course
    {
        [Key]
        public int ID{ get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Name{ get; set; }
        public int Hours{ get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Classroom{ get; set; }
        public int ECTS { get; set; }
        public ICollection<Student>? Students { get; set; }
        public ICollection<Professor>? Professors { get; set; }
        public Lab? Lab { get; set; }
    }
}