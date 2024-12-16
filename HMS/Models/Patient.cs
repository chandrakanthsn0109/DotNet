using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        [DisplayName("Patient Name")]
        public string? PatientName { get; set; }

        [Required]
        public string? Disease { get; set; }

        [ForeignKey("Doctor")]
        [DisplayName("Doctor Id")]
        public int? DocId { get; set; }
    }
}
