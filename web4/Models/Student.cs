namespace web4.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Student (int id, string name, string email, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
