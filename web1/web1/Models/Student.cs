namespace web1.Models
{
    public class Student
    {
        public int id { get; set; } 
        public string name { get; set; }
        public int age { get; set; }
        public double grade { get; set; }

        public Student (int i, string n, int a, float g)
        {
            this.id = i;
            this.name = n;
            this.age = a;
            this.grade = g;
        }
    }
}
