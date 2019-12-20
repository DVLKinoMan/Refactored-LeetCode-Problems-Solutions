using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class ReconstructA2RowBinaryMatrix
    {
        [TestMethod]
        public void Method1()
        {
            ReconstructMatrix(9, 2, new int[] { 0, 1, 2, 0, 0, 0, 0, 0, 2, 1, 2, 1, 2 });
        }
    }
}
