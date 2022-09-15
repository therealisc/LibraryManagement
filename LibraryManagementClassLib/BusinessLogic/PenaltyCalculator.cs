using LibraryManagementClassLib.Models;

namespace LibraryManagementClassLib.BusinessLogic
{
    public class PenaltyCalculator
    {
        public decimal Calculate(BookModel book)
        {
            var maximumDateOfReturn = book.LendingDate.Value.AddDays(14);

            if (maximumDateOfReturn.Date < DateTime.Now.Date)
            {
                decimal lateDays = (decimal)(DateTime.Now.Date - maximumDateOfReturn.Date).TotalDays;

                var penalty = lateDays * 0.01m * (book.LendingDelayPrice);

                return penalty;
            }

            return 0;
        }
    }
}
