using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Robodoc.Data.Models
{
    public class Patient
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Vorname { get; set; }
        [Required]
        public DateTime EintrittDatum { get; set; }
        public DateTime? AustrittDatum { get; set; }
        public string? Anamnese { get; set; }
    }
}
