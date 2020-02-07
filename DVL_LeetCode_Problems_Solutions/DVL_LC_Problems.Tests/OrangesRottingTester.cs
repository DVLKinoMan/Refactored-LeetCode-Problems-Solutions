using NUnit.Framework;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestFixture]
    public class OrangesRottingTester
    {
        [Test]
        public void TestMethod1()
        {
           int res= OrangesRotting(new int[][]
            {
                new int[] {2, 1, 1},
                new int[] {1, 1, 0},
                new int[] {0, 1, 1}
            });
            
            Assert.That(res, Is.EqualTo(4));
        }
    }
}