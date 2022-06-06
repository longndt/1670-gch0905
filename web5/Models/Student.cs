using System;
using System.ComponentModel.DataAnnotations;

namespace web5.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(8, ErrorMessage = "Student Id must be 8 characters")]
        public string Sid { get; set; }

        [MinLength(3)]
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string MobilePhone { get; set; }

        [Range(1,4)]
        public int StudentYear { get; set; }

        [Range(0,10)]
        public float? Grade { get; set; } //nullable ==> required = false
 
        [IsBefore("01/01/2022")]
        public DateTime BirthDay { get; set; }

        public string Address { get; set; }

    }
}
