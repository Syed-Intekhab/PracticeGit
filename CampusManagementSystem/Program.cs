using CampusManagementSystem.Data;
using CampusManagementSystem.Models;

namespace CampusManagementSystem
{
    class Program
    {
        // Milestone 3
        //public static List<string> _students = [];

        // Milestone 4
        //public static int[] _studentMarks = new int[5];
        //public static int[] _studentAges = new int[5];

        // Milestone 5
        //public static List<(string, int, int)> _students = [];

        //public struct Student(string name)
        //{
        //    public string Name = name ?? "Unknown";
        //    public int Age = -1;
        //    public int RollNumber = -1;

        //    // Constructor
        //    //public Student(string name)
        //    //{
        //    //    this.Name = name;
        //    //}
        //}

        public static void Main(string[] args)
        {
            DisplayMenu();


            // Practice - Milestone 1 and 2
            #region
            //Helpers.GetStudentName(out string studentName);
            //Helpers.GetStudentAge(out byte studentAge);
            //Helpers.DisplayStudentDetails(studentName, studentAge);
            #endregion

            // Practice - Milestone 3
            #region
            //for (int i = 0; i < 5; i++)
            //{
            //    Helpers.GetStudentName(out string studentName);
            //    _students.Add(studentName);
            //}

            //foreach(var student in _students)
            //{
            //    Helpers.PrintLine($"Student Name: {student}");
            //}

            //Console.WriteLine();
            //// Update student at index 2
            //Helpers.GetStudentName(out string updatedName);
            //_students[2] = updatedName;

            //// Delete student at index 3
            //_students.RemoveAt(3);

            //// Add a new student
            //Helpers.GetStudentName(out string newStudentName);
            //_students.Add(newStudentName);

            //Helpers.PrintLine("Updated Student List:");
            //foreach(var student in _students)
            //{
            //    Helpers.PrintLine($"Student Name: {student}");
            //}
            #endregion

            // Practice - Milestone 4
            #region
            // Handle Marks Input and Display
            //for (int i = 0; i < _studentMarks.Length; i++)
            //{
            //    _studentMarks[i] = Helpers.ReadInt($"Enter marks for student {i + 1}: ");
            //}

            //Console.WriteLine();
            //foreach(var marks in _studentMarks)
            //{
            //    Helpers.PrintLine($"Student Marks: {marks}");
            //}
            //Console.WriteLine();

            //// Handle Ages Input and Display
            //for (int i = 0; i < _studentAges.Length; i++)
            //{
            //    Helpers.GetStudentAge(out byte age);
            //    _studentAges[i] = age;
            //}

            //Console.WriteLine();
            //foreach (var age in _studentAges)
            //{
            //    Helpers.PrintLine($"Student Age: {age}");
            //}
            //Console.WriteLine();
            #endregion

            // Practice - Milestone 5
            #region
            //// var student1 = ("John Doe", 18, 101);
            //var student2 = ("Jane Doe", 20, 102);

            ////Helpers.DisplayTuple(student1);
            ////Console.WriteLine();
            ////Helpers.DisplayTuple(student2);

            //_students.Add(("John Doe", 18, 101));
            //_students.Add(student2);

            //foreach (var student in _students)
            //{
            //    Helpers.DisplayTuple(student);
            //    Console.WriteLine();
            //}

            //Student s1 = new Student();
            //Student s2 = new("John");
            //Student s3 = new Student("Alice");
            //Student s4 = new();

            //s1.Age = 19;
            //s1.RollNumber = 201;

            //s2.Age = 21;

            //s3.RollNumber = 202;

            //Helpers.PrintLine($"Student Name: {s1.Name}, Age: {s1.Age}, Roll Number: {s1.RollNumber}");
            //Helpers.PrintLine($"Student Name: {s2.Name}, Age: {s2.Age}, Roll Number: {s2.RollNumber}");
            //Helpers.PrintLine($"Student Name: {s3.Name}, Age: {s3.Age}, Roll Number: {s3.RollNumber}");
            //Helpers.PrintLine($"Student Name: {s4.Name}, Age: {s4.Age}, Roll Number: {s4.RollNumber}");
            #endregion

            // Practice - Milestone 6
            #region
            ////Student student = new Student(1, "Alice Smith", 20, "alice@example.com");
            //Student student = new(1, "Alice Smith", 20, "alice@example.com");
            //Teacher teacher = new(1, "Dr. John Doe", "Mathematics");
            //Course course = new(1, "Calculus", 4);

            //Helpers.PrintLine(student.ToString());
            //Helpers.PrintLine(teacher.ToString());
            //Helpers.PrintLine(course.ToString());
            #endregion

            // Practice - Milestone 7
            #region
            SchoolRepository repo = new();

            //repo.AddStudent(new Student(1, "Alice Smith", 20, "alice@demo.com"));
            //repo.AddStudent(new Student(2, "Bob Johnson", 22, "bob@demo.com"));
            //repo.AddStudent(new Student(3, "Charlie Brown", 19, "charlie@example.com"));
            //repo.AddStudent(new Student(4, "Diana Prince", 21, "diana@demo.com"));

            //IReadOnlyList<Student> students = repo.GetAllStudents();

            while (true)
            {
                Helpers.Print("\nEnter your choice: ");

                int id;
                IReadOnlyList<Student> students;

                switch (Console.ReadLine())
                {
                    case "1":
                        repo.AddStudent(Helpers.ReadStudent());
                        Console.WriteLine("Student added successfully!");
                        break;
                    case "2":
                        students = repo.GetAllStudents();
                        if (students.Count == 0)
                        {
                            Console.WriteLine("No students found!");
                            break;
                        }
                        foreach (var student in students)
                        {
                            Helpers.PrintLine(student.ToString());
                        }
                        break;
                    case "3":
                        id = Helpers.ReadInt("Enter student id to update: ");
                        students = repo.GetAllStudents();

                        if (students.FirstOrDefault(s => s.Id == id) == null)
                        {
                            Console.WriteLine("Student not found!");
                            break;
                        }

                        if (repo.UpdateStudentById(id, Helpers.ReadStudent()))
                        {
                            Console.WriteLine("Student updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Student not found!");
                        }
                        break;
                    case "4":
                        id = Helpers.ReadInt("Enter student id: ");
                        Helpers.Print($"Are you sure you wanna delete {id} student? Y/N: ");
                        if (char.ToUpperInvariant(Console.ReadLine()?[0] ?? 'N') == 'Y')
                        {
                            if (repo.RemoveStudentById(id))
                            {
                                Console.WriteLine("Student removed successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Student not found!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Delete operation cancelled.");
                        }
                        break;
                    case "5":
                        Helpers.PrintLine("\n\n===============================================================");
                        foreach (char c in "Exiting the program. Goodbye!")
                        {
                            Helpers.Print(c.ToString());
                            Thread.Sleep(60);
                        }
                        Helpers.PrintLine("\n===============================================================");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            #endregion
        }

        public static void DisplayMenu()
        {
            Helpers.PrintLine("====================== Welcome to Campus ======================");
            Helpers.PrintLine("1. Add Student");
            Helpers.PrintLine("2. View Students");
            Helpers.PrintLine("3. Update Student");
            Helpers.PrintLine("4. Delete Student");
            Helpers.PrintLine("5. Exit");
            Helpers.PrintLine("===============================================================\n");
        }
    }
}