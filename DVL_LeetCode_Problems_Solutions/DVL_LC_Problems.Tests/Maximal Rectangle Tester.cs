using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class MaximalRectangleTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            MaximalRectangle(new char[1][] { new char[2] { 'd', 'd' } });
        }
    }
}
