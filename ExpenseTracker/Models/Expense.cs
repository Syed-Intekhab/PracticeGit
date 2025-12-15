namespace ExpenseTracker.Models
{
    internal class Expense(int amount, string? name, string? category)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Amount { get; set; } = amount;
        public string? Name { get; set; } = name;
        public string? Category { get; set; } = category;
    }
}
