namespace CampusManagementSystem.Models
{
    internal class Teacher(int id, string name, string subject)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Subject { get; set; } = subject;

        //public Teacher(int id, string name, string subject)
        //{
        //    Id = id;
        //    Name = name;
        //    Subject = subject;
        //}

        public override string ToString() => $"ID: {Id}, Name: {Name}, Subject: {Subject}";
    }
}
