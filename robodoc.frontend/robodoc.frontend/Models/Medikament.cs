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

    public class Medikament
    {
        public Guid id { get; set; }
        public string? name { get; set; }
        public Einheiten? einheit { get; set; }
        public Verabreichungsprozess? verabreichungsprozess { get; set; }
    }
}
