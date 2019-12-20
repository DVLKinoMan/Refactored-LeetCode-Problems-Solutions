using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class MinimumMovesToReachTargestWithRotationsTester
    {
        [TestMethod]
        public void TestMethod1()
        {
            MinimumMoves(new int[][]
            {
                new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
                new int[] {1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0},
                new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                new int[] {0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                new int[] {0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0},
                new int[] {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
                new int[] {0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0},
                new int[] {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                new int[] {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1},
                new int[] {0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                new int[] {0, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0},
                new int[] {0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0},
                new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0},
                new int[] {0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0},
                new int[] {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            });
        }
    }
}
