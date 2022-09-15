using LibraryManagementClassLib.Models;

namespace LibraryManagementClassLib.DataAccess
{
    public class BookData
    {
        public BookData()
        {
            BookStore = new()
            {
                new BookModel
                {
                    Id = "13e24",
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    LendingDelayPrice = 15.25m,
                    Isbn = "ISBN-1324"
                },
                new BookModel
                {
                    Id = "132f4",
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    LendingDelayPrice = 15.25m,
                    Isbn = "ISBN-1325"
                },
                new BookModel
                {
                    Id = "132d4",
                    Title = "The Will to Meaning",
                    Author = "Victor Frankl",
                    LendingDelayPrice = 20.50m,
                    Isbn = "ISBN-1326"
                },
                new BookModel
                {
                    Id = "13s24",
                    Title = "Taming the Infinite",
                    Author = "Ian Stewart",
                    LendingDelayPrice = 18.75m,
                    Isbn = "ISBN-1327"
                }
            };
        }
        public List<BookModel> GetAllBooks()
        {
            return BookStore;
        }

        public List<BookModel> GetAllBooksByTitle(string title)
        {
            return BookStore
                .Where(x => x.Title.ToLower() == title.ToLower())
                .ToList();
        }

        public List<BookModel> GetAvailableBooksByTitle(string title)
        {
            var books = GetAllBooksByTitle(title);
            return books
                .Where(x => x.LendingDate == null)
                .ToList();
        }

        public List<BookModel> GetLentBooksByTitle(string title)
        {
            var books = GetAllBooksByTitle(title);
            return books
                .Where(x => x.LendingDate != null)
                .ToList();
        }

        public void AddBook(BookModel book)
        {
            BookStore.Add(book);
        }

        public static List<BookModel> BookStore { get; set; } 
    }
}
