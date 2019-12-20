using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class UniquePathIiTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            UniquePathsWithObstacles(new int[][]
            {
                new int[]{1,0}
            });
        }
    }
}
