using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace robodoc.backend.Data.Models
{
    public class RoboActivityStatus
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int Status { get; set; }
        [ForeignKey(nameof(RoboOrt))]
        public Guid RoomId { get; set; }
        public RoboOrt RoboOrt { get; set; }
        [ForeignKey(nameof(RoboActivity))]
        public Guid ActivityId { get; set; }
        public RoboActivity RoboActivity { get; set; }
    }
}
