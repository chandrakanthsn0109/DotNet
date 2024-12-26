using System.ComponentModel.DataAnnotations;

namespace CoreApiEF.Models
{
    public class PetAnimal
    {

        [Key]
        public int petId { get; set; }
        public string petName { get; set; }
        public string petType { get; set; }
        public string DOB { get; set; }
        public bool isVeg {  get; set; }
    }
}
