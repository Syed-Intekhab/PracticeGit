using CampusManagementSystem.Models;
using System.Dynamic;

namespace CampusManagementSystem.Data
{
    internal class SchoolRepository
    {
        public List<Student> Students { get; set; } = [];
        public List<Teacher> Teachers { get; set; } = [];
        public List<Course> Courses { get; set; } = [];
    }
}
