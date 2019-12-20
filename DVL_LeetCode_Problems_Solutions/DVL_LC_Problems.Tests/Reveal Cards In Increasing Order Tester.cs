using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class RevealCardsInIncreasingOrderTester
    {
        [TestMethod]
        public void Method1()
        {
            DeckRevealedIncreasing(new int[] { 17, 13, 11, 2, 3, 5, 7 });
        }
    }
}
