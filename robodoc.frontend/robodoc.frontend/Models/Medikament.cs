using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace robodoc.frontend.Models
{
    public enum Einheiten
    {
        Tabletten,
        Kapseln,
        Tropfen,
        Brausetabletten,
        Kautabletten,
        mg_ml,
        Ampullen,
        Zäpfchen
    }

    public enum Verabreichungsprozess
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

    [Table("MedikamentTB")]
    public class Medikament
    {
        [Key]
        public Guid id { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Enter Einheit")]
        public Einheiten? einheit { get; set; }
        [Required(ErrorMessage = "Enter Verabreichungsprozess")]
        public Verabreichungsprozess? verabreichungsprozess { get; set; }
        public IEnumerable<MedikamentTherapie> medikamentTherapies { get; set; }

    }
}
