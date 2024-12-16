using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS.Models
{
    public class Doctor
    {
        [Key]
        public int DocId { get; set; }
        [Required]
        [DisplayName("Doctor Name")]
        public string? DocName { get; set; }
        [Required]
        public string? Qualification { get; set; }
        [Required]
        public string? Specality { get; set; }

       
        [DisplayName("Hospital Id")]
        [ForeignKey("Hospital")]
        public int HosId { get; set; }

    }
}
