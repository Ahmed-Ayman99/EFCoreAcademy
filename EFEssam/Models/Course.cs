using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFEssam.Models
{
    public class Course
    {
        [Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public decimal Price { get; set; }

        // One To One
        public ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}
