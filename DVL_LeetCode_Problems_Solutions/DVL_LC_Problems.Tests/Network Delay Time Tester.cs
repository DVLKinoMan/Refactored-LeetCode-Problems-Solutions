using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class NetworkDelayTimeTester
    {
        [TestMethod]
        public void Method1()
        {
            NetworkDelayTime(new int[][] { new int[] { 1, 2, 1 }, new int[] { 2, 3, 2 }, new int[] { 1, 3, 2 } },
                3,
                1);
        }
    }
}
