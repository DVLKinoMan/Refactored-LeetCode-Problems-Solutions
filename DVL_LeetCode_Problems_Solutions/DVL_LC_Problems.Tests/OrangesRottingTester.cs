using System;
using NUnit.Framework;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestFixture]
    public class OrangesRottingTester
    {

        private static readonly object[] CaseSource =
        {
            new object[]
            {
                new int[][]
                {
                    new int[] {2, 1, 1},
                    new int[] {1, 1, 0},
                    new int[] {0, 1, 1}
                },
                4
            },
            new object[]
            {
                new int[][]
                {
                    new int[] {2, 1, 1},
                    new int[] {0, 1, 1},
                    new int[] {1, 0, 1}
                },
                -1
            },
            new object[]
            {
                new int[][]
                {
                    new int[] {0, 2}
                },
                0
            }
        };
        
        [Test, TestCaseSource("CaseSource")]
        public void TestMethod1(int[][] grid, int expected)
        {
            int res = OrangesRotting(grid);

            Assert.That(res, Is.EqualTo(expected));
        }
    }
}