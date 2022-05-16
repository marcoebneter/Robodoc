using System.ComponentModel.DataAnnotations;

namespace robodoc.backend.Data.Models
{
    public class Personal
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsArzt { get; set; }
    }
}
