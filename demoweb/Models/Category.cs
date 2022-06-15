using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace demoweb.Models
{
    public class Category
    {
        //primary key (auto-increment)
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        [MinLength(3, ErrorMessage = "Category Name must be at least 3 characters")]
        [MaxLength(30, ErrorMessage = "Category Name cannot be more than 30 characters")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Category Description")]
        [StringLength(100, ErrorMessage = "Category Description must be from 10 to 100 characters", MinimumLength = 10)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Cagegory Image")]
        [Url]
        public string Image { get; set; }

        //relational attribute (One to Many)
        public ICollection<Product> Products { get; set; }
    }
}