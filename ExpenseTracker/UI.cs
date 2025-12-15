using Microsoft.VisualBasic;

namespace ExpenseTracker
{
    class UI
    {
        // App Menu
        public static void DisplayMenu()
        {
            InfoMessage("\n=================================================");
            InfoMessage("\nExpense Tracker Menu:\n");
            InfoMessage("1. Add Expense\n");
            InfoMessage("2. View Total Expenses\n");
            InfoMessage("3. Generate Expense Report\n");
            InfoMessage("4. Exit\n");
            InfoMessage("\nSelect an option: ");
        }

        // Exit Message
        public static void ExitMessage()
        {
            InfoMessage("\n=================================================\n");
            ErrorMessage("Exiting the application. Goodbye!\n");
            InfoMessage("=================================================\n");
        }

        // Success Message
        public static void SuccessMessage(string val)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(val);
            Console.ResetColor();
        }

        // Error Message
        public static void ErrorMessage(string val)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write(val);
            Console.ResetColor();
        }

        // Warning Message
        public static void WarningMessage(string val)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(val);
            Console.ResetColor();
        }

        // Info Message
        public static void InfoMessage(string val)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(val);
            Console.ResetColor();
        }
    }
}