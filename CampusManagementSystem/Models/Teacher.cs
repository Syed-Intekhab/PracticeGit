namespace CampusManagementSystem.Models
{
    internal class Teacher(int id, string name, string subject) : Person(id, name)
    {
        public string Subject { get; set; } = subject;

        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }
        //public Teacher(int id, string name, string subject)
        //{
        //    Id = id;
        //    Name = name;
        //    Subject = subject;
        //}

        public override string ToString() => $"ID: {Id}, Name: {Name}, Subject: {Subject}";
    }
}
