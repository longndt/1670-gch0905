using System;
using System.ComponentModel.DataAnnotations;

namespace demoweb.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product Name can not be empty")]
        public string Name { get; set; }

        [Required]
        [Range(1, 100000, ErrorMessage = "Price must be between 1$ and 100000$")]
        public double Price { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Quantity must be between 0 and 1000")]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Manufacturer Date")]
        public DateTime Date { get; set; }

        [Required]
        public int CategoryId { get; set; }
        
        public Category category { get; set; }
    }   
}
