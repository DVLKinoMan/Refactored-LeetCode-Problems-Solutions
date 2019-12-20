using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class GetEqualSubstringsWithinBudgetTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            EqualSubstring("thjdoffka",
                "qhrnlntls",
                11);
        }
    }
}
