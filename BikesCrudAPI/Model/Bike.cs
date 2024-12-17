using System.ComponentModel.DataAnnotations;

namespace BikesCrudAPI.Model
{
    public class Bike
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Company { get; set; }

        public int? Cc { get; set; }
    }
}
