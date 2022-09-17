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
                    Id = 1,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    LendingDelayPrice = 15.25m,
                    Isbn = "978-0-7432-7356-5"
                },
                new BookModel
                {
                    Id = 2,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    LendingDelayPrice = 15.25m,
                    Isbn = "978-0-7432-7356-5"
                },
                new BookModel
                {
                    Id = 3,
                    Title = "The Will to Meaning",
                    Author = "Victor Frankl",
                    LendingDelayPrice = 20.50m,
                    Isbn = "978-606-40-1003-2"
                },
                new BookModel
                {
                    Id = 4,
                    Title = "Taming the Infinite",
                    Author = "Ian Stewart",
                    LendingDelayPrice = 18.75m,
                    Isbn = "978-162-36-5474-0"
                }
            };
        }
        public List<BookModel> GetAllBooks()
        {
            return BookStore;
        }

        public List<BookModel> GetSpecificBook(string isbnPublicationElement)
        {
            return BookStore
                .Where(x => x.Isbn.Split("-")[3] == isbnPublicationElement)
                .ToList();
        }

        public BookModel GetBookById(int id)
        {
            return BookStore
                .Where(x => x.LendingDate == null)
                .FirstOrDefault(x => x.Id == id);
        }

        public BookModel GetLentBookById(int id) 
        {
            return BookStore
                .Where(x => x.LendingDate != null)
                .FirstOrDefault(x => x.Id == id);
        }

        public void AddBook(BookModel book)
        {
            book.Id = IdLookup();
            BookStore.Add(book);
        }

        public bool IsbnLookup(string isbn)
        {
            var existentBook = BookStore.FirstOrDefault(x => x.Isbn == isbn);
            if (existentBook != null)
            {
                BookModel book = new()
                {
                    Isbn = existentBook.Isbn,
                    Title = existentBook.Title,
                    Author = existentBook.Author
                };

                AddBook(book);
                return true;
            }
            else
            {
                return false;
            }
        }

        private int IdLookup()
        {
            return BookStore.Last().Id + 1;
        }

        public static List<BookModel> BookStore { get; set; } 
    }
}
