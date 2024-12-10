using System.ComponentModel.DataAnnotations;

namespace SampleMVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        [MaxLength(6)]
        public string? Department { get; set; }
        public int? Salary { get; set; }
    }
}
