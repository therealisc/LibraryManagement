namespace LibraryManagementClassLib.Models
{
    public class PersonModel
    {
        public string Id { get; set; } = new Guid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
