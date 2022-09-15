namespace LibraryManagementConsoleUI
{
    internal class UserInputHelper
    {
        public static string GetStringUserInput()
        {
            string input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input! Try again!");
                input = Console.ReadLine();
            }

            return input.Trim();
        }

        public static decimal GetDecimalUserInput()
        {
            string input = GetStringUserInput();
            decimal decimalInput;

            while (decimal.TryParse(input, out decimalInput) == false)
            {
                Console.WriteLine("Type a decimal value!");
                input = GetStringUserInput();
            }

            return decimalInput;
        }
    }
}
