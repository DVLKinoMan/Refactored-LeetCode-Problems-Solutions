using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Burst Balloons (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxCoins(int[] nums)
        {
            var list = nums.ToList();
            list.Insert(0, 1);
            list.Add(1);

            var dp = new int[list.Count, list.Count];
            for (int len = 1; len <= list.Count; len++)
            for (int start = 0; start < list.Count; start++)
            {
                int end = start + len - 1;

                if (end >= list.Count)
                    continue;

                if (start == end)
                {
                    dp[start, end] = list[start];
                    continue;
                }

                for (int i = start + 1; i <= end - 1; i++)
                    dp[start, end] = Math.Max(dp[start, end],
                        list[i] * list[start] * list[end] + dp[start, i] + dp[i, end]);
            }

            return dp[0, list.Count - 1];
        }
    }
}
