using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Robodoc.Data.Models
{
    public class TherapieverfahrenDurchfuehrung
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime Zeitpunkt { get; set; }

        [ForeignKey(nameof(Personal))]
        public Guid PersonalId { get; set; }
        public Personal Personal { get; set; }

        [ForeignKey(nameof(Therapieverfahren))]
        public Guid TherapieverfahrenId { get; set; }
        public Therapieverfahren Therapieverfahren { get; set; }
    }
}
