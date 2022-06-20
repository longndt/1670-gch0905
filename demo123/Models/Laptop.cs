using System.ComponentModel.DataAnnotations;

namespace demo123.Models
{
    public class Laptop
    {
        public int Id { get; set; }

        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Range(10, 2000)]
        public double Price { get; set; }

        public string Manufacturer { get; set; }
    }
}
