using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Robodoc.Data.Models
{
    [Flags]
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

    [Flags]
    public enum Verabreichungsprozesse
    {
        oral,
        lingual,
        sublingual,
        intravenoes,
        intraarteriell,
        intramuskulaer,
        kutan,
        subkutan,
        intrakutan,
        perkutan,
        nasal,
        konjunktival,
        rektal,
        vaginal
    }

    public class Medikament
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Einheiten Einheit { get; set; }
        [Required]
        public Verabreichungsprozesse Verabreichungsprozess { get; set; }
        public IEnumerable<MedikamentTherapie> MedikamentTherapies  { get; set; }
    }
}
