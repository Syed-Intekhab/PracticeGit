using CampusManagementSystem.Models;

namespace CampusManagementSystem
{
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
                //throw new ArgumentOutOfRangeException("Please enter a valid age!");
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

        public static void DisplayTuple((string, int, int) tuple)
        {
            PrintLine($"Name: {tuple.Item1}");
            PrintLine($"Age: {tuple.Item2}");
            PrintLine($"Roll Number: {tuple.Item3}");
        }

        public static Student ReadStudent()
        {
            int id = ReadInt("Enter student id: ");
            GetStudentName(out string studentName);
            GetStudentAge(out byte studentAge);
            Print("Enter student email: ");
            string mail = Console.ReadLine() ?? "unknown@invalidmail.com";

            return new Student(id, studentName, studentAge, mail);
        }
    }
}