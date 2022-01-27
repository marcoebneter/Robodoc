using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Robodoc.Data.Models
{
    public class MedikamentTherapie
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public int Menge { get; set; }

        [ForeignKey(nameof(Medikament))]
        public string MedikamentId { get; set; }
        public Medikament Medikament { get; set; }

        [ForeignKey(nameof(Therapie))]
        public string TherapieId { get; set; }
        public Therapie Therapie { get; set; }
    }
}
