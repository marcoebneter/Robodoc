using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Robodoc.Data.Models
{
    public class TherapieverfahrenDurchfuehrung
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public DateTime Zeitpunkt { get; set; }

        [ForeignKey(nameof(Personal))]
        public string PersonalId { get; set; }
        public IdentityUser Personal { get; set; }

        [ForeignKey(nameof(Therapieverfahren))]
        public string TherapieverfahrenId { get; set; }
        public Therapieverfahren Therapieverfahren { get; set; }
    }
}
