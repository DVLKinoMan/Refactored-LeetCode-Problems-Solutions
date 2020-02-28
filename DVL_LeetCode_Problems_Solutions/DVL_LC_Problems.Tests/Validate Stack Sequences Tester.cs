using NUnit.Framework;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestFixture]
    public class Validate_Stack_Sequences_Tester
    {
        [Test]
        public void TestMethod1()
        {
            ValidateStackSequences(
                new int[] {1, 2, 3, 4, 5},
                new int[] {4, 5, 3, 2, 1});
        }
    }
}