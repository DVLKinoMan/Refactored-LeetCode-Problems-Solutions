using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Smallest Range II (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int SmallestRangeII(int[] A, int K)
        {
            Array.Sort(A);

            int n = A.Length, mx = A[n - 1], mn = A[0], res = mx - mn;
            for (int i = 0; i < n - 1; ++i)
            {
                mx = Math.Max(mx, A[i] + 2 * K);
                mn = Math.Min(A[i + 1], A[0] + 2 * K);
                res = Math.Min(res, mx - mn);
            }
            return res;
        }
    }
}
