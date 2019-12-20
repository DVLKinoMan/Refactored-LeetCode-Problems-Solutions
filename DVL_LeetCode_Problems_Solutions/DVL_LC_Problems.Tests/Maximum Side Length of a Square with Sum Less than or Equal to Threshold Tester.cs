using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class MaximumSideLengthOfASquareWithSumLessThanOrEqualToThresholdTester
    {
        [TestMethod]
        public void Method1()
        {
            MaxSideLength(new int[3][]
            {
                new int[3] {1, 1, 1},
                new int[3] {1, 1, 1},
                new int[3] {1, 1, 1},
            }, 3);
        }
    }
}
