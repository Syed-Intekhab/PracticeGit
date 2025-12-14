namespace CampusManagementSystem.Models
{
    abstract class Person(int id, string name)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public abstract void DisplayInfo();
    }
}
