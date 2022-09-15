using LibraryManagementClassLib.BusinessLogic;
using LibraryManagementClassLib.Models;

namespace LibraryManagementTests
{
    public class PenaltyCalculatorTests
    {
        public static IEnumerable<object[]> GetBooksForTesting()
        {
            yield return new object[]
            {
                new BookModel {LendingDate = DateTime.Now.AddDays(-14), LendingDelayPrice = 12.50m},
                new BookModel {LendingDate = DateTime.Now.AddDays(-20), LendingDelayPrice = 12.50m},
                new BookModel {LendingDate = DateTime.Now.AddDays(-15), LendingDelayPrice = 64.45m},
            };
        }

        [Theory]
        [MemberData(nameof(GetBooksForTesting))]
        public void Calculate_penalties_if_returned_after_two_weeks(BookModel firstBook, BookModel secondBook, BookModel thirdBook)
        {
            //Arrage
            PenaltyCalculator penaltyCalculator = new();

            //Act
            decimal firstBookActualPenalty = penaltyCalculator.Calculate(firstBook);
            decimal secondBookActualPenalty = penaltyCalculator.Calculate(secondBook);
            decimal thirdBookActualPenalty = penaltyCalculator.Calculate(thirdBook);

            //Assert
            Assert.Equal(0, firstBookActualPenalty);
            Assert.Equal(0.75m, secondBookActualPenalty);
            Assert.Equal(0.6445m, thirdBookActualPenalty);
        }
    }
}