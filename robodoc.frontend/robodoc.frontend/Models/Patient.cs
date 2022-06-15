using System.ComponentModel.DataAnnotations;

namespace robodoc.frontend.Models
{
    public class Patient
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string vorname { get; set; }
        [Required]
        public int zimmer { get; set; }
        [Required]
        public DateTime eintrittDatum { get; set; }
        public DateTime? austrittDatum { get; set; }
        public string? anamnese { get; set; }
    }
}
