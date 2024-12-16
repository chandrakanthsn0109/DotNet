using System.ComponentModel.DataAnnotations;

namespace DMS.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Qualification { get; set; }
        public string? Specality { get; set; }

    }
}
