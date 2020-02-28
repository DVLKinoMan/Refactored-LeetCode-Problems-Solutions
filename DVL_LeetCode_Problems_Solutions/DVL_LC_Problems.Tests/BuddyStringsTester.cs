using NUnit.Framework;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestFixture]
    public class BuddyStringsTester
    {
        [Test]
        [TestCase("ab", "ab", false)]
        [TestCase("abc", "bca", false)]
        public void TestMethod1(string a, string b, bool expected)
        {
            Assert.AreEqual(BuddyStrings(a, b), expected);
        }
    }
}