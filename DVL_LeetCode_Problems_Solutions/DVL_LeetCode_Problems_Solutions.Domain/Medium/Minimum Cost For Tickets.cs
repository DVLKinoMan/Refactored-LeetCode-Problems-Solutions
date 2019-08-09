using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Cost For Tickets (Not Mine)
        /// </summary>
        /// <param name="days"></param>
        /// <param name="costs"></param>
        /// <returns></returns>
        public static int MincostTickets(int[] days, int[] costs)
        {
            var set = new HashSet<int>(days);
            int[] dp = new int[366];
            for (int i = 1; i < dp.Length; i++)
                if (!set.Contains(i))
                    dp[i] = dp[i - 1];
                else dp[i] = Math.Min(dp[i - 1] + costs[0], Math.Min(dp[Math.Max(0, i - 7)] + costs[1], dp[Math.Max(0, i - 30)] + costs[2]));

            return dp[365];
        }
    }
}
