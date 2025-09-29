using System;
using System.Runtime.Remoting.Services;

namespace PracticeGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print Hello, World!
            Console.WriteLine("Hello World!");

            // Add another change
            Console.WriteLine("Second Change in Git!");

            // Checking Difference
            Console.WriteLine("Third line of Git Learning!");

            // Adding this in shaan/feature-greeting branch
            Console.WriteLine("Hello from feature branch!");

            // Adding this line in main branch to make a conflict
            Console.WriteLine("Main branch says hello!");

            // Adding this line in shaan/feature-greeting branch to make a conflict
            Console.WriteLine("Feature branch says hello!");

            // Adding this line to check if it makes a pull request on github? this line present on main branch
            Console.WriteLine("Try to pull a request!");

            // Deleted the branch shaan/feature-greeting after merging it to main branch
            Console.WriteLine("This line is added after deleting the shaan/feature-greeting branch...");

            // Practice code from Syed Intekhab
            Console.WriteLine("Hello World!");

            // Practice pull request from visual studio to github
            Console.WriteLine("Pull Request!");

            // Practuce pull request from another branch
            Console.WriteLine("Pull Request From Another Branch!");

            // New changes in local master branch to pull changes in local shaan/feature-console branch
            Console.WriteLine("Get these changes in another branch!");

            // Understood Everything
            Console.Write("Enter your age: ");
            int.TryParse(Console.ReadLine(), out int age);

            if (age > 17)
                Console.WriteLine("You can vote!");
            else
                Console.WriteLine("You can't vote!");

            // Calculator Program In shaan/calculator-program Branch
            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.Write("Enter choice: ");
            int.TryParse(Console.ReadLine(), out int choice);

            Calculate(num1, num2, choice);

            // Even Odd Program In shaan/even-odd Branch
            Console.WriteLine("Enter any number: ");
            int.TryParse(Console.ReadLine(), out int num);
            IsEven(num);
        }

        static void Calculate(int num1, int num2, int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Addition of {num1} and {num2} is: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Subtraction: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication: {num1 * num2}");
                    break;
                case 4:
                    if (num2 < 1)
                        Console.WriteLine("Can not devide a number with zero!");
                    else
                        Console.WriteLine($"Division: {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }

        static void IsEven(int num)
        {
            if(num % 2 == 0)
                Console.WriteLine($"{num} is even!");
            else
                Console.WriteLine($"{num} is odd!");
        }
    }
}
