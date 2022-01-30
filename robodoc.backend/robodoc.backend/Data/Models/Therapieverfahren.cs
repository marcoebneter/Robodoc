using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace Robodoc.Data.Models
{
    public class Therapieverfahren
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public TimeSpan Intervall { get; set; }

        [ForeignKey(nameof(Patient))]
        public string PatientId { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey(nameof(Zustaendigkeit))]
        public string PersonalId { get; set;}
        public IdentityUser Zustaendigkeit { get; set;}

        [ForeignKey(nameof(Therapie))]
        public string TherapieId { get; set; }
        public Therapie Therapie { get; set; }

        public IEnumerable<TherapieverfahrenDurchfuehrung> TherapieverfahrenDurchfuehrungen { get; set; }
    }
}
