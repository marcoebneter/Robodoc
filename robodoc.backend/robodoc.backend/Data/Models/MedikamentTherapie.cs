using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Robodoc.Data.Models
{
    public class MedikamentTherapie
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int Menge { get; set; }


        [ForeignKey(nameof(Medikament))]
        public Guid MedikamentId { get; set; }
        public Medikament Medikament { get; set; }


        [ForeignKey(nameof(Therapie))]
        public Guid TherapieId { get; set; }
        public Therapie Therapie { get; set; }
    }
}
