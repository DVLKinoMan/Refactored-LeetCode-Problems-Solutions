using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class MaximumScoreWordsFormedByLettersTester
    {
        [TestMethod]
        public void Method1()
        {
            MaxScoreWords(new string[] {"xxxz", "ax", "bx", "cx"},
                new Char[] {'z', 'a', 'b', 'c', 'x', 'x', 'x'},
                new int[] {4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10});
        }
    }
}
