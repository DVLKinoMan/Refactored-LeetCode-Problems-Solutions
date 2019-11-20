using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class StoneGameIITester
    {
        [TestMethod]
        public void Method1()
        {
            int d = StoneGameII(new int[] { 2, 7, 9, 4, 4 });
            //CircularPermutation(2, 3);
            //MinRemoveToMakeValid("lee(t(c)o)de)");
            //ReconstructMatrix(9, 2, new int[] {0, 1, 2, 0, 0, 0, 0, 0, 2, 1, 2, 1, 2});
            //MaxScoreWords(new string[] {"xxxz", "ax", "bx", "cx"},
            //    new Char[] {'z', 'a', 'b', 'c', 'x', 'x', 'x'},
            //    new int[] {4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10});
            //Subsets(new int[] {1, 2, 3});
            //MySqrt(11111111);

            //MaxSumDivThree(new int[] {1, 1, 5, 4, 7});
            //ReconstructQueue(new int[][]
            //{
            //    new int[]{9, 0},new int[]{7, 0},new int[]{1, 9},new int[]{3, 0},new int[]{2, 7},new int[]{5, 3},new int[]{6, 0},new int[]{3, 4},new int[]{6, 2},new int[]{5, 2}
            //});
            //CanPartition(new int[]
            //{
            //    1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            //    1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            //    1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 100
            //});

            GetSum(-1, 1);

            Assert.AreEqual(10, d);
        }
    }
}
