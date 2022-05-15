using Robodoc.Data.Models;

namespace robodoc.backend.Controllers.DTO
{
    public class MedikamentDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Einheit { get; set; }
        public string Verabreichungsprozess { get; set; }
    }
}
