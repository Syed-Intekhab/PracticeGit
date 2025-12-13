using System;

namespace CampusManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Helpers.PrintLine("====================== Welcome to Campus ======================");
            Helpers.PrintLine("1. Add Student");
            Helpers.PrintLine("2. View Students");
            Helpers.PrintLine("3. Update Student");
            Helpers.PrintLine("4. Delete Student");
            Helpers.PrintLine("5. Exit");
            Helpers.PrintLine("===============================================================\n\n");

            Helpers.GetStudentName(out string studentName);
            Helpers.GetStudentAge(out byte studentAge);
            Helpers.DisplayStudentDetails(studentName, studentAge);
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

            while (!byte.TryParse(Console.ReadLine(), out studentAge) || (studentAge <= 0 || studentAge >= 50))
            {
                Print("Invalid age. Please enter a valid age: ");
            }
        }

        public static void DisplayStudentDetails(string name, byte age)
        {
            PrintLine($"\nStudent Name: {name}, Age: {age}\n");
        }
    }
}