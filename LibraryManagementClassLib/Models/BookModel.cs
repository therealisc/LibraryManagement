namespace LibraryManagementClassLib.Models
{
    public class BookModel
    {
        public string Id { get; set; } = new Guid().ToString();
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public decimal LendingPrice { get; set; }
    }
}
