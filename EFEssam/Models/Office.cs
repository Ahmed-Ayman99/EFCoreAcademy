using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFEssam.Models
{
    public class Office
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? OfficeName { get; set; }
        public string? OfficeLocation { get; set; }
        public Instructor? Instructor { get; set; }
    }
}
