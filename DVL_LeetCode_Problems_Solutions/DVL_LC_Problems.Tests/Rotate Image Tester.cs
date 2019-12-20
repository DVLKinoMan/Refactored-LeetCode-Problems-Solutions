using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class RotateImageTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            Rotate(new int[3][]
            {
                new int[3] { 1, 2, 3 },
                new int[3] { 4, 5, 6 },
                new int[3] { 7, 8, 9 }
            });
        }
    }
}
