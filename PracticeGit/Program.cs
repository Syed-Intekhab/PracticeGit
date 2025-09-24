using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}