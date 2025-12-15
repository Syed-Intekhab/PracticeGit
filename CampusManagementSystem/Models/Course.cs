namespace CampusManagementSystem.Models
{
    internal class Course(int id, string title, int credits)
    {
        public int Id { get; set; } = id;
        public string Title { get; set; } = title;
        public int Credits { get; set; } = credits;

        //public Course(int id, string title, int credits)
        //{
        //    Id = id;
        //    Title = title;
        //    Credits = credits;
        //}

        public override string ToString() => $"ID: {Id}, Title: {Title}, Credits: {Credits}";
    }
}
