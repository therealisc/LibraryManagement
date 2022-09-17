namespace LibraryManagementConsoleUI.BookOperations
{
    internal class BookLending
    {
        private readonly BookData _bookData;
        private readonly PenaltyCalculator _penaltyCalculator;

        public BookLending(BookData bookData, PenaltyCalculator penaltyCalculator)
        {
            _bookData = bookData;
            _penaltyCalculator = penaltyCalculator;
        }

        public void LendBook()
        {
            Console.WriteLine("Type the ID of the book you want to lend:");
            int bookId = (int)UserInputHelper.GetDecimalUserInput();

            BookModel book = _bookData.GetBookById(bookId);

            if (book is null)
            {
                Console.WriteLine("Unavailable book!");
            }
            else
            {
                book.LendingDate = DateTime.Now;
                Console.WriteLine("Book lent!");
            }
        }

        public void ReturnBook()
        {
            Console.WriteLine("Type the ID of the book you want to return:");
            int bookId = (int)UserInputHelper.GetDecimalUserInput();

            BookModel book = _bookData.GetLentBookId(bookId);

            if (book is null)
            {
                Console.WriteLine("This book was not lent!");
            }
            else
            {
                Console.WriteLine("Book returned!");

                decimal penalty = _penaltyCalculator.Calculate(book);
                Console.WriteLine($"Penalty for delay: {penalty}");
                book.LendingDate = null;
            }
        }
    }
}
