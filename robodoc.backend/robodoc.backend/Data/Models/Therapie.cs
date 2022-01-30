using System.ComponentModel.DataAnnotations;

namespace Robodoc.Data.Models
{
    public class Therapie
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IEnumerable<MedikamentTherapie> MedikamentTherapies { get; set; }
        public IEnumerable<Therapieverfahren> Therapieverfahren { get; set; }
    }
}
