namespace robodoc.frontend.Models
{
    public class MedikamentTherapie
    {
        public Guid id { get; set; }
        public int menge { get; set; }
        public Guid medikament { get; set; }
        public Guid therapie { get; set; }
    }
}
