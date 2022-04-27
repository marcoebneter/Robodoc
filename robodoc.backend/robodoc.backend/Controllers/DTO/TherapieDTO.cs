using Robodoc.Data.Models;

namespace robodoc.backend.Controllers.DTO
{
    public class TherapieDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Medikament> Medikaments { get; set; }
    }
}
