using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        private static int[][] arrs;
        private static int arrsIndex = 0;
        private static Random rnd = new Random();

        public static void Solution(int[][] rects)
        {
            arrs = rects.Where(r => r.Length != 0).ToArray();
        }

        /// <summary>
        /// Random Point in Non-overlopping Rectangle (Do not Works)
        /// </summary>
        /// <returns></returns>
        public static int[] pick()
        {
            arrsIndex = ++arrsIndex >= arrs.Length ? 0 : arrsIndex;

            int x = rnd.Next(arrs[arrsIndex][0], arrs[arrsIndex][2] + 1);
            int y = rnd.Next(arrs[arrsIndex][1], arrs[arrsIndex][3] + 1);

            return new int[] {x, y};
        }

    }
}
