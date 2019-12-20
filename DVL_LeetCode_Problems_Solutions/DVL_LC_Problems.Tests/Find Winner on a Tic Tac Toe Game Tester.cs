using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class FindWinnerOnATicTacToeGameTester
    {
        [TestMethod]
        public void Method1()
        {
            Tictactoe(new int[][]
            {
                new int[] {0, 0}, new int[] {1, 1}, new int[] {0, 1}, new int[] {0, 2}, new int[] {1, 0},
                new int[] {2, 0}
            });
        }
    }
}
