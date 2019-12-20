using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class ColorBorderTester
    {
        [TestMethod]
        public void Method1()
        {
            ColorBorder(new int[][]
                {
                    new int[]{1, 1, 1},
                    new int[]{1, 1, 1},
                    new int[]{1, 1, 1}
                },
                1,
                1,
                2
            );
        }
    }
}
