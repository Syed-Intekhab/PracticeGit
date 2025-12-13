using System;

namespace CampusManagementSystem
{
    class Program
    {
        public static List<string> _students = [];
        public static int[] _studentMarks = new int[5];
        public static int[] _studentAges = new int[5];

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
            for (int i = 0; i < _studentMarks.Length; i++)
            {
                _studentMarks[i] = Helpers.ReadInt($"Enter marks for student {i + 1}: ");
            }

            Console.WriteLine();
            foreach(var marks in _studentMarks)
            {
                Helpers.PrintLine($"Student Marks: {marks}");
            }
            Console.WriteLine();

            // Handle Ages Input and Display
            for (int i = 0; i < _studentAges.Length; i++)
            {
                Helpers.GetStudentAge(out byte age);
                _studentAges[i] = age;
            }

            Console.WriteLine();
            foreach (var age in _studentAges)
            {
                Helpers.PrintLine($"Student Age: {age}");
            }
            Console.WriteLine();
            #endregion
        }
    }

    class Helpers
    {
        public static void PrintLine(string val)
        {
            Console.WriteLine(val);
        }

        public static void Print(string val)
        {
            Console.Write(val);
        }

        public static void GetStudentName(out string studentName)
        {
            Print("Enter student name: ");
            studentName = Console.ReadLine() ?? string.Empty;

            while (string.IsNullOrWhiteSpace(studentName))
            {
                Print("Student name cannot be empty. Please enter a valid name: ");
                studentName = Console.ReadLine() ?? string.Empty;
            }

            studentName = studentName.Trim();
        }

        public static void GetStudentAge(out byte studentAge)
        {
            Print("Enter student age: ");

            while (!byte.TryParse(Console.ReadLine(), out studentAge) || studentAge <= 0 || studentAge >= 50)
            {
                Print("Invalid age. Please enter a valid age: ");
            }
        }

        public static void DisplayStudentDetails(string name, byte age)
        {
            PrintLine($"\nStudent Name: {name}, Age: {age}\n");
        }

        public static int ReadInt(string prompt)
        {
            int result;
            Print(prompt);

            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Print("Invalid input. " + prompt);
            }

            return result;
        }
    }
}