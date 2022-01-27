using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace robodoc.backend.Data.Models
{
    public class RoboActivityStatus
    {
        public enum Ort;
        [Key]
        public string Id { get; set; }
        [Required]
        public int Status { get; set; }
        [ForeignKey(nameof(RoboOrt))]
        public string OrtId { get; set; }
        public RoboOrt RoboOrt { get; set; }
        [ForeignKey(nameof(RoboActivity))]
        public string ActivityId { get; set; }
        public RoboActivity RoboActivity { get; set; }
    }
}
