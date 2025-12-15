namespace ExpenseTracker.Models
{
    internal class Expense(int amount, string? name, string? category)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Amount { get; set; } = amount;
        public string? Name { get; set; } = name;
        public string? Category { get; set; } = category;

        public static double GenerateReport(double budget, Expense[] expenses)
        {
            double amount = 0;

            foreach (var expense in expenses)
            {
                if (expense == null) continue;
                amount += expense.Amount;
            }

            budget -= amount;

            return budget;
        }
    }
}
