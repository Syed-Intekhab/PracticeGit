using CampusManagementSystem.Models;

namespace CampusManagementSystem.Data
{
    internal class SchoolRepository
    {
        private readonly List<Student> _students = [];
        private readonly List<Teacher> _teachers = [];
        private readonly List<Course> _courses = [];

        public void AddStudent(Student student)
        {
            if (student is null) throw new ArgumentNullException(nameof(student));
            _students.Add(student);
        }

        // Expose a read-only view to prevent external mutation
        public IReadOnlyList<Student> GetAllStudents() => _students.AsReadOnly();

        // Remove by id - return true if removed
        public bool RemoveStudentById(int id)
        {
            var idx = _students.FindIndex(s => s.Id == id);
            if (idx == -1) return false;
            _students.RemoveAt(idx);
            return true;
        }

        // Update student by id - return true if updated
        public bool UpdateStudentById(int id, Student updatedStudent)
        {
            if(updatedStudent is null) throw new ArgumentNullException(nameof(updatedStudent));
            var idx = _students.FindIndex(s => s.Id == id);
            if (idx == -1) return false;
            _students[idx] = updatedStudent;
            return true;
        }
    }
}