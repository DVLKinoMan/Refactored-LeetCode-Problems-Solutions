using System;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Form Largest Integer With Digits That Add up to Target (Not Mine)
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string LargestNumber(int[] cost, int target)
        {
            int[] dp = new int[target + 1];
            for (int t = 1; t <= target; ++t) {
                dp[t] = -10000;
                for (int i = 0; i < 9; ++i)
                    if (t >= cost[i])
                        dp[t] = Math.Max(dp[t], 1 + dp[t - cost[i]]);
            }
            if (dp[target] < 0)
                return "0";
            var res = new StringBuilder();
            for (int i = 8; i >= 0; --i) {
                while (target >= cost[i] && dp[target] == dp[target - cost[i]] + 1) {
                    res.Append(1 + i);
                    target -= cost[i];
                }
            }
            return res.ToString();
        }
    }
}