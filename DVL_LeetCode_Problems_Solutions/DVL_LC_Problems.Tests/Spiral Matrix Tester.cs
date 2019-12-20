using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class SpiralMatrixTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            SpiralOrder(new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{1,2,3,4},
                new int[]{1,2,3,4},
            });
        }
    }
}
