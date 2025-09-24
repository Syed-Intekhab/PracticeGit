using System;

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
        }
    }
}