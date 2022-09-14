using LibraryManagementClassLib.DataAccess;
using LibraryManagementClassLib.Models;
using LibraryManagementConsoleUI;

MessageHelper.PrintStartMessages();

BookData bookData = new BookData();

while (true)
{
    Console.Write("\nPress a valid key: ");
    string userInput = Console.ReadLine();

    switch (userInput.Trim())
    {
        case "1":
            RegisterNewBook();
            break;

        case "2":
            GetAllBooks();
            break;

        case "3":
            FindAvailableBooksByTitle();
            break;

        case "c":
            Console.Clear();
            MessageHelper.PrintStartMessages();
            break;

        case "x":
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("That is not a valid key!");
            break;
    }
}



void RegisterNewBook()
{
    BookModel book = new();

    Console.WriteLine("Enter the name of the book:");
    book.Name = Console.ReadLine();

    Console.WriteLine("Enter the name of the writer (optional):");
    book.Author = Console.ReadLine();

    Console.WriteLine("Enter the ISBN:");
    book.Isbn = Console.ReadLine();

    Console.WriteLine("Enter the lending price:");
    book.LendingPrice = Convert.ToDecimal(Console.ReadLine());

    BookData bookData = new();
    bookData.AddBook(book);

    Console.WriteLine("Registration done!\n");
}