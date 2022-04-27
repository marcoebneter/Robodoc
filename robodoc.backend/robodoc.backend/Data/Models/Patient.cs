using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Robodoc.Data.Models
{
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Vorname { get; set; }
        [Required]
        public DateTime EintrittDatum { get; set; }
#nullable enable
        public DateTime? AustrittDatum { get; set; }
        public string? Anamnese { get; set; }
#nullable disable
        public IEnumerable<Therapieverfahren> Therapieverfahren { get; set; }
    }
}
