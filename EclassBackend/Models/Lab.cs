using System.ComponentModel.DataAnnotations.Schema;

namespace EclassBackend.Models
{
    public class Lab
    {
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        public int Hours { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Classroom { get; set; }
    }
}