using System;
using System.Linq;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;
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
            //GetSum(-1, 1);
            //string maxString = System.Convert.ToString(int.MaxValue, 2);
            //string minusString = System.Convert.ToString(-1, 2);
            //bool b = maxString == minusString;
            //int l = System.Convert.ToInt32(maxString, 2);
            //int minusNum = System.Convert.ToInt32(minusString, 2);

            //FindSubsequences(new int[] {4, 6, 7, 7});
            //DecodeString("3[a2[c]]");

            //OddEvenList(new ListNode(1)
            //{
            //    next = new ListNode(2)
            //    {
            //        next = new ListNode(3)
            //        {
            //            next = new ListNode(4)
            //            {
            //                next = new ListNode(5)
            //            }
            //        }
            //    }
            //});
            //Tictactoe(new int[][]
            //{
            //    new int[] {0, 0}, new int[] {1, 1}, new int[] {0, 1}, new int[] {0, 2}, new int[] {1, 0},
            //    new int[] {2, 0}
            //});
            //CanReorderDoubled(new int[] {7, -15, -15, 23, -3, 80, -35, 40, 68, 22, 44, 98, 20, 0, -34, 8, 40, 41, 16, 46, 16, 49, -6, -11, 35, -15, -74, 72, -8, 60, 40, -2, 0, -6, 34, 14, -16, -92, 54, 14, -68, 82, -30, 50, 22, 25, 16, 70, -1, -96, 11, 45, 54, 40, 92, -35, 29, 80, 46, -30, 27, 7, -70, -37, 41, -46, -98, 1, -33, -24, -86, -70, 80, -43, 98, -49, 30, 0, 27, 2, 82, 36, 0, -48, 3, -100, 58, 32, 90, -22, -50, -12, 36, 6, -3, -66, 72, 8, 49, -30});
            //FindDuplicate(new int[] { 3, 1, 3, 4, 2 });
            //DeckRevealedIncreasing(new int[] {17, 13, 11, 2, 3, 5, 7});
            //ValidTicTacToe(new string[] {"OXX", 
            //"XOX", 
            //"OXO"});
            //CountSubstrings("abcabc");

            //MaxSideLength(new int[3][]
            //{
            //    new int[3] {1, 1, 1},
            //    new int[3] {1, 1, 1},
            //    new int[3] {1, 1, 1},
            //}, 3);

            //ShortestPath(new int[][]
            //    {
            //        new int[] {0, 1, 0, 0, 0, 1, 0, 0},
            //        new int[] {0, 1, 0, 1, 0, 1, 0, 1},
            //        new int[] {0, 0, 0, 1, 0, 0, 1, 0}
            //    },
            //    1);

            NextGreatestLetter(
                new string[]
                {
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l", "l",
                    "l", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o",
                    "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o"
                }.Select(s => s[0]).ToArray(),
                'a');


            Assert.AreEqual(10, d);
        }
    }
}
