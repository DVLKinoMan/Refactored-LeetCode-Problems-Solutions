using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class MaximizeDistanceToClosestPersonTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            MaxDistToClosest(new int[] {1, 0, 0, 0, 1, 0, 1});
        }
    }
}
