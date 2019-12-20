using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class ShortestSubarrayWithSumAtLeastKTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            var res = ShortestSubarray(new[] { 84, -37, 32, 40, 95 }, 167);
            Assert.AreEqual(3, res);
        }
    }
}
