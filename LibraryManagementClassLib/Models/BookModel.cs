namespace LibraryManagementClassLib.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public decimal LendingDelayPrice { get; set; }
        public DateTime? LendingDate { get; set; }
    }
}
