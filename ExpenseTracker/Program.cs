using ExpenseTracker.Models;

namespace ExpenseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Milestone 1/2/3/4/5
            #region
            // int budget;
            //int[] expenses = new int[10];
            //int index = 0;

            //// Take user input for name and budget
            //Console.Write("Enter your name: ");
            //string? name = Console.ReadLine();

            //// Display welcome message
            //Console.WriteLine($"Welcome {name}! Your monthly budget is {GetValidAmount("Enter your monthly budget: ")}.\n");

            //// Show menu until user decides to exit
            //while (true)
            //{
            //    DisplayMenu();
            //    int choice = int.Parse(Console.ReadLine() ?? "0");

            //    switch (choice)
            //    {
            //        case 1: 
            //            expenses[index++] = GetValidAmount("Enter expense amount: ");
            //            break;
            //        case 2:
            //            foreach (var expense in expenses)
            //            {
            //                if (expense != 0)
            //                    Console.WriteLine($"Expense: {expense}");
            //            }
            //            break;
            //        case 3:
            //            Console.WriteLine("Exiting the application. Goodbye!");
            //            return;
            //        default:
            //            Console.WriteLine("Invalid option. Please try again.");
            //            break;
            //    }
            //}
            #endregion

            //Milestone 6
            #region
            Expense[] expenses = new Expense[10];
            int index = 0;

            // Take user input for name and budget
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            // Display welcome message
            Console.WriteLine($"Welcome {name}! Your monthly budget is {GetValidAmount("Enter your monthly budget: ")}.\n");

            // Show menu until user decides to exit
            while (true)
            {
                DisplayMenu();
                int choice = int.Parse(Console.ReadLine() ?? "0");

                switch (choice)
                {
                    case 1:
                        if(index >= expenses.Length)
                        {
                            Console.WriteLine("Expense limit reached. Cannot add more expenses.");
                            break;
                        }
                        Console.Write("Enter expense name: ");
                        string? expenseName = Console.ReadLine();
                        int expenseAmount = GetValidAmount("Enter expense amount: ");
                        Console.Write("Enter expense category: ");
                        string? expenseCategory = Console.ReadLine();

                        expenses[index++] = new Expense(expenseAmount, expenseName, expenseCategory);
                        break;
                    case 2:
                        foreach (var expense in expenses)
                        {
                            if (expense != null && expense.Amount != 0)
                            {
                                Console.WriteLine($"Name: {expense.Name}");
                                Console.WriteLine($"Expense: {expense.Amount}");
                                Console.WriteLine($"Category: {expense.Category}\n");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Exiting the application. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            #endregion
        }

        // Method to get and validate budget input
        static int GetValidAmount(string message)
        {
            int amount;

            Console.Write(message);
            // Validate budget input (Loop until a valid integer is entered)
            while (!int.TryParse(Console.ReadLine(), out amount))
            {
                Console.Write($"Invalid input. {message}");
            }

            return amount;
        }

        // App Menu
        public static void DisplayMenu()
        {
            Console.WriteLine("\nExpense Tracker Menu:");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Total Expenses");
            Console.WriteLine("3. Exit");
            Console.Write("\nSelect an option: ");
        }
    }
}