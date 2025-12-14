namespace CampusManagementSystem
{
    internal class UI
    {
        public static void DisplayMenu()
        {
            Helpers.PrintMessage("====================== Welcome to Campus ======================", ConsoleColor.Green);
            Helpers.PrintMessage("1. Add Student", ConsoleColor.Blue);
            Helpers.PrintMessage("2. View Students", ConsoleColor.Blue);
            Helpers.PrintMessage("3. Update Student", ConsoleColor.Blue);
            Helpers.PrintMessage("4. Delete Student", ConsoleColor.Blue);
            Helpers.PrintMessage("5. Search Student by ID", ConsoleColor.Blue);
            Helpers.PrintMessage("6. Count Students", ConsoleColor.Blue);
            Helpers.PrintMessage("7. Get Students by Age Range", ConsoleColor.Blue);
            Helpers.PrintMessage("8. Get Student Admission Number By ID", ConsoleColor.Blue);
            Helpers.PrintMessage("8. Exit", ConsoleColor.Blue);
            Helpers.PrintMessage("===============================================================\n", ConsoleColor.Green);
        }

        public static void DisplayExit()
        {
            Helpers.PrintMessage("\n\n===============================================================", ConsoleColor.Blue);
            foreach (char c in "Exiting the program. Goodbye!")
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                finally
                {
                    Helpers.Print(c.ToString());
                    Console.ResetColor();
                }
                Thread.Sleep(50);
            }
            Helpers.PrintMessage("\n===============================================================", ConsoleColor.Blue);
        }
    }
}
