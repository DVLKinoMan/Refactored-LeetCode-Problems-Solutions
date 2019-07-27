using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum of Absolute Value Expression (Not Mine)
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int MaxAbsValExpr(int[] arr1, int[] arr2)
        {
            int res = 0;
            var P = new int[] {-1, 1};
            foreach (var p in P)
            foreach (var q in P)
            {
                int closest = p * arr1[0] + q * arr2[0] + 0;
                for (int i = 1; i < arr1.Length; i++)
                {
                    int curr = p * arr1[i] + q * arr2[i] + i;
                    res = Math.Max(res, curr - closest);
                    closest = Math.Min(curr, closest);
                }
            }

            return res;
        }
    }
}
