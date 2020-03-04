using NUnit.Framework;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestFixture]
    public class Find_Maximum_XOR_Tester
    {
        [Test]
        public void TestMethod1()
        {
            FindMaximumXOR(new int[] {3, 10, 5, 25, 2, 8});
        }
    }
}