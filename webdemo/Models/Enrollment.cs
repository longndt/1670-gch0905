namespace webdemo.Models
{
    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Enrollment
    {
        //primary key (PK)
        public int EnrollmentId { get; set; }
        
        //foreign key (FK)
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        
        //data type: enum Grade
        public Grade Grade { get; set; }

        //navigation properties
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}