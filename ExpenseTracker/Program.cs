namespace ExpenseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget;

            // Take user input for name and budget
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            

            // Display welcome message
            Console.WriteLine($"Welcome {name}! Your monthly budget is {GetValidatedBudget("Enter your monthly budget: ")}.");
        }

        // Method to get and validate budget input
        static int GetValidatedBudget(string message)
        {
            int budget;

            Console.Write(message);
            // Validate budget input (Loop until a valid integer is entered)
            while (!int.TryParse(Console.ReadLine(), out budget))
            {
                Console.Write($"Invalid input. {message}");
            }

            return budget;
        }
    }
}