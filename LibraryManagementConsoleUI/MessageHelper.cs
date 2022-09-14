using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementConsoleUI
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
                              "\nc - to clear the console" +
                              "\nx - to exit");
        }
    }
}
