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

            Console.Write("Enter your monthly budget: ");
            // Validate budget input (Loop until a valid integer is entered)
            while (!int.TryParse(Console.ReadLine(), out budget))
            {
                Console.Write("Invalid input. Please enter a valid number for your monthly budget: ");
            }

            // Display welcome message
            Console.WriteLine($"Welcome {name}! Your monthly budget is {budget}.");
        }
    }
}