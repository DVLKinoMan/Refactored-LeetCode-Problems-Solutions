using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class FindTheDuplicateNumberTester
    {
        [TestMethod]
        public void Method1()
        {
            FindDuplicate(new int[] { 3, 1, 3, 4, 2 });
        }
    }
}
