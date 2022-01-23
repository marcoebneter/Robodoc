using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Robodoc.Models;

namespace Robodoc.Data.Models
{
    public class Therapieverfahren
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public TimeSpan Intervall { get; set; }

        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey(nameof(Zustaendigkeit))]
        public string PersonalId { get; set;}
        public ApplicationUser Zustaendigkeit { get; set;}

        [ForeignKey(nameof(Therapie))]
        public Guid TherapieId { get; set; }
        public Therapie Therapie { get; set; }
    }
}
