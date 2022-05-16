using System.ComponentModel.DataAnnotations;

namespace robodoc.backend.Data.Models
{
    public class RoboActivity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public IEnumerable<RoboActivityStatus> ActivityStatuses { get; set; }
    }
}
