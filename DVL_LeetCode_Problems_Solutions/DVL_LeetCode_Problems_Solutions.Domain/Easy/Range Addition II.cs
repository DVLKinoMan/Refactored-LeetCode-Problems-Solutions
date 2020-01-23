using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Range Addition II (Mine)
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="ops"></param>
        /// <returns></returns>
        public static int MaxCount(int m, int n, int[][] ops)
        {
            if (ops.Length == 0)
                return m * n;

            int minA = int.MaxValue, minB = int.MaxValue;
            foreach (var op in ops)
            {
                minA = Math.Min(minA, op[0]);
                minB = Math.Min(minB, op[1]);
            }

            return minA * minB;
        }
    }
}
