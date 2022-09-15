namespace LibraryManagementConsoleUI.Helpers
{
    internal class MessageHelper
    {
        public static void PrintStartMessages()
        {
            Console.WriteLine("Library Management App\n");

            Console.WriteLine("Execute a command by entering one of the following keys:" +
                              "\n1 - to add a book" +
                              "\n2 - to show all books" +
                              "\n3 - to find available books based on title" +
                              "\n4 - to lend a book" +
                              "\n5 - to return a book" +
                              "\nc - to clear the console" +
                              "\nx - to exit");
        }
    }
}
