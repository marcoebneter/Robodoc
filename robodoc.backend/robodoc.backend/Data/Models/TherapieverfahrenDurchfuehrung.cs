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
        public string PersonalId { get; set; }
        public ApplicationUser Personal { get; set; }

        [ForeignKey(nameof(Therapieverfahren))]
        public Guid TherapieverfahrenId { get; set; }
        public Therapieverfahren Therapieverfahren { get; set; }
    }
}
