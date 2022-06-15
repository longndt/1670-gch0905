using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webdemo.Models
{
    public class Student
    {
        //Primary Key (Auto Increment)
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First & Middle Name")]
        [MinLength(5)]
        [MaxLength(50)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        //Navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
