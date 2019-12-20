using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class SquaresOfASortedArrayTester
    {
        [TestMethod]
        public void Method1()
        {
            SortedSquares(new int[] {-4, -1, 0, 3, 10});
        }
    }
}
