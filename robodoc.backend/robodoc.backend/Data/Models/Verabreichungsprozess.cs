using System.ComponentModel.DataAnnotations;

namespace Robodoc.Data.Models
{
    public class Verabreichungsprozess
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<Medikament> Medikamente { get; set; }
    }
}
