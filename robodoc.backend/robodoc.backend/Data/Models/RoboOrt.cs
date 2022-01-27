using System.ComponentModel.DataAnnotations;

namespace robodoc.backend.Data.Models
{
    public class RoboOrt
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
