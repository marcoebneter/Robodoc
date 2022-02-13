using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Robodoc.Data.Models
{
    public enum Einheiten
    {
        Tabletten,
        Kapseln,
        Tropfen,
        Brausetabletten,
        Kautabletten,
        [Display(Name = "mg/ml")]
        mg_ml,
        Ampullen,
        Zäpfchen
    }
    public class Medikament
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Einheiten Einheit { get; set; }

        [ForeignKey(nameof(Verabreichungsprozess))]
        public string VerabreichungsprozessId { get; set; }
        public Verabreichungsprozess Verabreichungsprozess { get; set; }

        public IEnumerable<MedikamentTherapie> MedikamentTherapies  { get; set; }
    }
}
