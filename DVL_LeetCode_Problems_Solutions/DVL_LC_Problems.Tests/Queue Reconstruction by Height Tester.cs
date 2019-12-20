using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class QueueReconstructionByHeightTester
    {
        [TestMethod]
        public void Method1()
        {
            ReconstructQueue(new int[][]
            {
                new int[]{9, 0},new int[]{7, 0},new int[]{1, 9},new int[]{3, 0},new int[]{2, 7},new int[]{5, 3},new int[]{6, 0},new int[]{3, 4},new int[]{6, 2},new int[]{5, 2}
            });
        }
    }
}
