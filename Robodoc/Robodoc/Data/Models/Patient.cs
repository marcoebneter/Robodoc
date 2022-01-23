using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Robodoc.Data.Models
{
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime EintrittDatum { get; set; }
        public DateTime? AustrittDatum { get; set; }
        public string? Anamnese { get; set; }

        [ForeignKey(nameof(Person))]
        public Guid PersonId { get; set; }
        public Person Person { get; set; }
    }
}
