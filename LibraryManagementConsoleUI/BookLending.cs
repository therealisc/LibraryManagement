namespace LibraryManagementConsoleUI
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
            Console.WriteLine("Type the name of the book you want to lend:");
            string bookName = UserInputHelper.GetStringUserInput();

            BookModel book = _bookData.GetAvailableBooksByTitle(bookName).FirstOrDefault();

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
            Console.WriteLine("Type the name of the book you want to return:");
            string bookName = UserInputHelper.GetStringUserInput();

            BookModel book = _bookData.GetLentBooksByTitle(bookName).FirstOrDefault();

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
