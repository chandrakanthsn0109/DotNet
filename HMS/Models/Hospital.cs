using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class Hospital
    {
        [Key]
        public int HosId { get; set; }

        [Required]
        [DisplayName("Hospital Name")]
        public string? HosName { get; set; }

        [Required]
        [DisplayName("Hospital Location")]
        public string? HosLoc{ get; set; }
    }
}
