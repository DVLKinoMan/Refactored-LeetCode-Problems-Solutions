using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Delete and Earn (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int DeleteAndEarn(int[] nums)
        {
            int n = 10001;
            int[] values = new int[n];
            foreach (var num in nums)
                values[num] += num;

            int take = 0, skip = 0;
            for (int i = 0; i < n; i++)
            {
                int takei = skip + values[i];
                int skipi = Math.Max(skip, take);
                take = takei;
                skip = skipi;
            }

            return Math.Max(take, skip);
        }
    }
}
