﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class ShortestPathWithAlternatingColors
    {
        [TestMethod]
        public void TestMethod1()
        {
            //            var arr = ShortestAlternatingPaths(5,
            // new int[][]{
            //    new int[]{0, 1 },
            //new int[]{1, 2},
            //new int[]{2, 3},
            //new int[]{3, 4 }
            // },
            // new int[][]{
            //new int[]{1, 2 },
            //new int[]{2,3},
            //new int[]{3,1 } });

            var arr = ShortestAlternatingPaths(3,
                new int[][]
                {
                    new int[] {0, 1}
                },
                new int[][]
                {
                    new int[] {1, 2}
                });

            var expected = new int[] { 0, 1, 2, 3, 7 };

            for (int i = 0; i < arr.Length; i++)
                Assert.AreEqual(arr[i], expected[i]);
        }
    }
}
