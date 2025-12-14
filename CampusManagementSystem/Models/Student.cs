namespace CampusManagementSystem.Models
{
    internal class Student(int id, string name, byte age, string email)
    {
        // private byte _age;
        public Guid AdmissionNumber { get; } = Guid.NewGuid(); // Milestone 12 Assign a unique id to each instance
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public byte Age { get; set; } = age;
        public string Email { get; set; } = email;

        //public byte Age
        //{
        //    get { return _age; }
        //    set
        //    {
        //        if (value <= 0 || value >= 50)
        //        {
        //            throw new ArgumentOutOfRangeException("Age must be between 1 and 49.");
        //        }
        //        _age = value;
        //    }
        //}

        //public Student(int id, string name, byte age, string email)
        //{
        //    Id = id;
        //    Name = name;
        //    Age = age;
        //    Email = email;
        //}
        public override string ToString() => $"ID: {Id}, Name: {Name}, Age: {Age}, Email: {Email}";
        //public override string ToString()
        //{
        //    return $"ID: {Id}, Name: {Name}, Age: {Age}, Email: {Email}";
        //}
    }
}
