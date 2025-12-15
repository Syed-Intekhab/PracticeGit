namespace ExpenseTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter your monthly budget: ");
            _ = int.TryParse(Console.ReadLine(), out int budget);

            Console.WriteLine($"Welcome {name}! Your monthly budget is {budget}.");
        }
    }
}