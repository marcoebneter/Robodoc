using System.ComponentModel.DataAnnotations;

namespace robodoc.frontend.Models
{
    public class Therapie
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public string name { get; set; }
        public IEnumerable<MedikamentTherapie> medikamentTherapies { get; set; }
    }
}
