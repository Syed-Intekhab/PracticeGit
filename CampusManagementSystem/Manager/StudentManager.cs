using CampusManagementSystem.Data;
using CampusManagementSystem.Models;

namespace CampusManagementSystem.Manager
{
    internal class StudentManager
    {
        private readonly SchoolRepository _repository;

        // Constructor accepts the repository dependency.
        public StudentManager(SchoolRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // Expose a read-only view to prevent external mutation
        public IReadOnlyList<Student> GetAllStudents() => _repository.Students.AsReadOnly();

        // Get Student By ID
        public Student? GetStudentById(int id)
        {
            return _repository.Students.FirstOrDefault(s => s.Id == id);
        }

        // Add a new student
        public void AddStudent(Student student)
        {
            if (student is null) throw new ArgumentNullException(nameof(student));
            _repository.Students.Add(student);
        }

        // Update student by id - return true if updated
        public bool UpdateStudentById(int id, Student updatedStudent)
        {
            if (updatedStudent is null) throw new ArgumentNullException(nameof(updatedStudent));
            var idx = _repository.Students.FindIndex(s => s.Id == id);
            if (idx == -1) return false;
            _repository.Students[idx] = updatedStudent;
            return true;
        }

        // Remove by id - return true if removed
        public bool RemoveStudentById(int id)
        {
            var idx = _repository.Students.FindIndex(s => s.Id == id);
            if (idx == -1) return false;
            _repository.Students.RemoveAt(idx);
            return true;
        }

        // Get students by age range
        public IEnumerable<Student> GetStudentsByAgeRange(int minAge, int maxAge)
        {
            return _repository.Students.Where(s => s.Age >= minAge && s.Age <= maxAge);
        }

        // Student count
        public int CountStudents()
        {
            return _repository.Students.Count;
        }

        // Student admission number
        public void DisplayStudentAdmissionNumbers(int id)
        {
            Student? student = _repository.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                Helpers.PrintMessage($"Student Name: {student.Name}\nStudent Admission Number: {student.AdmissionNumber}", ConsoleColor.Yellow);
            }
            else
            {
                Helpers.PrintMessage("Student not found.", ConsoleColor.Red);
            }
        }
    }
}
