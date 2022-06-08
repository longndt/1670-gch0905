using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webdemo.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        [StringLength(30, ErrorMessage= "Course title length must be between 3 and 30",MinimumLength = 3)]
        public string Title { get; set; }

        [Range(1, 5, ErrorMessage = "Course credit must be between 1 and 5")]
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
