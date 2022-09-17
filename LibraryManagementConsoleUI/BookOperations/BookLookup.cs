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
                Console.WriteLine($"{book.Id} | {book.Isbn} | {book.Title}");
            }
        }

        internal void FindSpecificBook()
        {
            Console.WriteLine("Enter the publication element (forth string) of the ISBN:");
            string isbnPublicationElement = UserInputHelper.GetDecimalUserInput().ToString();

            var books = _bookData.GetSpecificBook(isbnPublicationElement);

            var availableBooks = books
                .Where(x => x.LendingDate == null)
                .Count();

            if (books.Any())
            {
                Console.WriteLine($"{availableBooks} book(s) availabe from a total of {books.Count} book(s):");
                foreach(var book in books)
                    Console.WriteLine($"{book.Id} | {book.Isbn} | {book.Title} | {book.Author} | {(book.LendingDate is null ? "available" : "lent")}");
            }
            else
            {
                Console.WriteLine("That book does not exist in the library!");
            }
        }
    }
}
