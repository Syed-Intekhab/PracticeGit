namespace CampusManagementSystem
{
    internal class UI
    {
        public static void DisplayMenu()
        {
            Helpers.PrintLine("====================== Welcome to Campus ======================");
            Helpers.PrintLine("1. Add Student");
            Helpers.PrintLine("2. View Students");
            Helpers.PrintLine("3. Update Student");
            Helpers.PrintLine("4. Delete Student");
            Helpers.PrintLine("5. Search Student by ID");
            Helpers.PrintLine("6. Count Students");
            Helpers.PrintLine("7. Get Students by Age Range");
            Helpers.PrintLine("8. Exit");
            Helpers.PrintLine("===============================================================\n");
        }

        public static void DisplayExit()
        {
            Helpers.PrintLine("\n\n===============================================================");
            foreach (char c in "Exiting the program. Goodbye!")
            {
                Helpers.Print(c.ToString());
                Thread.Sleep(60);
            }
            Helpers.PrintLine("\n===============================================================");
        }
    }
}
