using System.ComponentModel.DataAnnotations;

namespace Robodoc.Data.Models
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Vorname { get; set; }
    }
}
