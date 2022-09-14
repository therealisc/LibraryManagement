using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementConsoleUI
{
    internal class BookLookup
    {
        void GetAllBooks()
        {
            Console.WriteLine("Books in library:\n");

            var books = bookData.GetBooks();

            foreach (var book in books)
            {
                Console.WriteLine(book.Name);
            }
        }

        void FindAvailableBooksByTitle()
        {
            Console.WriteLine("Enter the name of the book you want to find:");
            string userIput = Console.ReadLine().ToLower();

            var books = bookData.GetBooks()
                .Where(x => x.Name.ToLower() == userIput);

            if (books.Any())
            {
                Console.WriteLine($"{books.Count()} book(s) available");
            }
            else
            {
                Console.WriteLine("No matching books!");
            }
        }
    }
}
