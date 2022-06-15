namespace robodoc.frontend.Models
{
    public class MedikamentTherapie
    {
        public Guid id { get; set; }
        public int menge { get; set; }
        public Guid medikamentId { get; set; }
        public Guid therapieId { get; set; }
    }
}
