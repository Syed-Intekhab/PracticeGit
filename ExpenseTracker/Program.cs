namespace ExpenseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // int budget;
            int[] expenses = new int[10];
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
                        expenses[index++] = GetValidAmount("Enter expense amount: ");
                        break;
                    case 2:
                        foreach (var expense in expenses)
                        {
                            if (expense != 0)
                                Console.WriteLine($"Expense: {expense}");
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