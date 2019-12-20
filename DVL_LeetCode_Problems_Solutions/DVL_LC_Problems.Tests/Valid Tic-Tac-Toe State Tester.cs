using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class ValidTicTacToeStateTester
    {
        [TestMethod]
        public void Method1()
        {
            ValidTicTacToe(new string[] {"OXX",
                "XOX",
                "OXO"});
        }
    }
}
