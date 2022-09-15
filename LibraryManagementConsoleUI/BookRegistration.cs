namespace LibraryManagementConsoleUI
{
    internal class BookRegistration
    {
        private readonly BookData _bookData;

        public BookRegistration(BookData bookData)
        {
            _bookData = bookData;
        }

        internal void RegisterNewBook()
        {
            BookModel book = new();

            Console.WriteLine("Enter the name of the book:");
            book.Title = UserInputHelper.GetStringUserInput();

            Console.WriteLine("Enter the name of the writer (optional):");
            book.Author = Console.ReadLine();

            Console.WriteLine("Enter the ISBN:");
            book.Isbn = UserInputHelper.GetStringUserInput();

            Console.WriteLine("Enter the lending price:");
            book.LendingDelayPrice = Convert.ToDecimal(UserInputHelper.GetDecimalUserInput());

            _bookData.AddBook(book);

            Console.WriteLine("Registration done!\n");
        }
    }
}
