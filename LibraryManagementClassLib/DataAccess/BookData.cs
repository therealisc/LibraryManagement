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
                    Name = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    LendingPrice = 15.25m,
                    Isbn = "ISBN-1324"
                },
                new BookModel
                {
                    Id = "132f4",
                    Name = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    LendingPrice = 15.25m,
                    Isbn = "ISBN-1325"
                },
                new BookModel
                {
                    Id = "132d4",
                    Name = "The Will to Meaning",
                    Author = "Victor Frankl",
                    LendingPrice = 20.50m,
                    Isbn = "ISBN-1326"
                },
                new BookModel
                {
                    Id = "13s24",
                    Name = "Taming the Infinite",
                    Author = "Ian Stewart",
                    LendingPrice = 18.75m,
                    Isbn = "ISBN-1327"
                }
            };
        }
        public List<BookModel> GetBooks()
        {
            return BookStore;
        }

        public void AddBook(BookModel book)
        {
            BookStore.Add(book);
        }

        public static List<BookModel> BookStore { get; set; } 
    }
}
