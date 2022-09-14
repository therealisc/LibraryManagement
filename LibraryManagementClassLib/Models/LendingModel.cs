namespace LibraryManagementClassLib.Models
{
    public class LendingModel
    {
        public List<BookModel> LentBooks { get; set; }
        public PersonModel Borrower { get; set; }
        public DateTime DateOfLent { get; set; }
        public DateTime DateOfReturn { get; set; }
    }
}
