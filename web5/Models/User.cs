using System;
using System.ComponentModel.DataAnnotations;

namespace web5.Models
{
    public class User
    {
        [MinLength(3)]
        [MaxLength(30)]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth{ get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string MobilePhone { get; set; }

        public bool Married { get; set; }
        
    }
}
