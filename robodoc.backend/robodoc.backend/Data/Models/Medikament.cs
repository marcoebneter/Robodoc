using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Robodoc.Data.Models
{
    public class Medikament
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Einheit { get; set; }

        [ForeignKey(nameof(Verabreichungsprozess))]
        public string VerabreichungsprozessId { get; set; }
        public Verabreichungsprozess Verabreichungsprozess { get; set; }
    }
}
