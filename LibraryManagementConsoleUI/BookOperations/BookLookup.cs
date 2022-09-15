namespace LibraryManagementConsoleUI.BookOperations
{
    internal class BookLookup
    {
        private readonly BookData _bookData;

        public BookLookup(BookData bookData)
        {
            _bookData = bookData;
        }

        internal void GetAllBooks()
        {
            Console.WriteLine("Books in library:\n");
            var books = _bookData.GetAllBooks();

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }

        internal void FindAvailableBooksByTitle()
        {
            Console.WriteLine("Enter the name of the book you want to find:");
            string userIput = Console.ReadLine();

            var books = _bookData.GetAvailableBooksByTitle(userIput);

            if (books.Any())
            {
                Console.WriteLine($"{books.Count} book(s) available");
            }
            else
            {
                Console.WriteLine("Unavailable book!");
            }
        }
    }
}
