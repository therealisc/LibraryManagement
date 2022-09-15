using LibraryManagementConsoleUI.BookOperations;
using LibraryManagementConsoleUI.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryManagementConsoleUI
{
    internal class OptionSetter
    {
        private readonly BookLookup _bookLookup;
        private readonly BookRegistration _bookRegistration;
        private readonly BookLending _bookLending;

        public OptionSetter(IServiceProvider serviceProvider)
        {
            _bookLookup = serviceProvider.GetRequiredService<BookLookup>();
            _bookRegistration = serviceProvider.GetRequiredService<BookRegistration>();
            _bookLending = serviceProvider.GetRequiredService<BookLending>();

            SetOptions();
        }

        private void SetOptions()
        {
            MessageHelper.PrintStartMessages();

            while (true)
            {
                Console.Write("\nPress a valid key: ");
                string userInput = Console.ReadLine();

                switch (userInput.Trim())
                {
                    case "1":
                        _bookRegistration.RegisterNewBook();
                        break;

                    case "2":
                        _bookLookup.GetAllBooks();
                        break;

                    case "3":
                        _bookLookup.FindAvailableBooksByTitle();
                        break;

                    case "4":
                        _bookLending.LendBook();
                        break;

                    case "5":
                        _bookLending.ReturnBook();
                        break;

                    case "c":
                        Console.Clear();
                        MessageHelper.PrintStartMessages();
                        break;

                    case "x":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("That is not a valid key!");
                        break;
                }
            }
        }
    }
}
