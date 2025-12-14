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
            Helpers.PrintLine("====================== Welcome to Campus ======================");
            Helpers.PrintLine("1. Add Student");
            Helpers.PrintLine("2. View Students");
            Helpers.PrintLine("3. Update Student");
            Helpers.PrintLine("4. Delete Student");
            Helpers.PrintLine("5. Exit");
            Helpers.PrintLine("===============================================================\n\n");


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
            //Student student = new Student(1, "Alice Smith", 20, "alice@example.com");
            Student student = new(1, "Alice Smith", 20, "alice@example.com");
            Teacher teacher = new(1, "Dr. John Doe", "Mathematics");
            Course course = new(1, "Calculus", 4);

            Helpers.PrintLine(student.ToString());
            Helpers.PrintLine(teacher.ToString());
            Helpers.PrintLine(course.ToString());
            #endregion
        }
    }
}