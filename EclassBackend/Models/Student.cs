using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace EclassBackend.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        public int GPA { get; set; }
        public bool hasThesis { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
