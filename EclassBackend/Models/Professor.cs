using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EclassBackend.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        public ICollection<Course>? Courses { get; set; }
        public ICollection<Lab>? Labs{ get; set; }
    }
}