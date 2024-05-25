using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFEssam.Models
{
    public class Student {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? FName { get; set; }

        public string? LName { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();

    }
}
