using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class PermutationIiTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            PermuteUnique(new int[]{1,2,3,4,4});
        }
    }
}
