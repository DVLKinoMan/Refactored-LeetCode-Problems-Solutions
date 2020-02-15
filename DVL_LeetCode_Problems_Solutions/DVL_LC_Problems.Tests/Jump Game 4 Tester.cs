using NUnit.Framework;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestFixture]
    public class Jump_Game_4_Tester
    {
        [Test]
        public void TestMethod()
        {
            MinJumps(new int[] {100, -23, -23, 404, 100, 23, 23, 23, 3, 404});
        }
    }
}