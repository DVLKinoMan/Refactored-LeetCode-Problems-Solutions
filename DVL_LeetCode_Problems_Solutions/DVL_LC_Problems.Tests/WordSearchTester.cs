using NUnit.Framework;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestFixture]
    public class WordSearchTester
    {
        [Test]
        public void TestMethod1()
        {
            Assert.That(Exist(new char[][]
            {
                new char[] {'A', 'B', 'C', 'E'},
                new char[] {'S', 'F', 'E', 'S'},
                new char[] {'A', 'D', 'E', 'E'},
            }, "ABCESEEEFS"), Is.EqualTo(true));
            ;
        }
    }
}