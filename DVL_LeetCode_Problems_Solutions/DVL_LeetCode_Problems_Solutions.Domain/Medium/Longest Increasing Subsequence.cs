using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Increasing Subsequence (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int[] dp = Enumerable.Repeat(-1, nums.Length).ToArray();
            int answer = 0;
            for (int j = 0; j < nums.Length; j++)
                 answer = Math.Max(answer, Dfs(j) + 1);

            return answer;

            int Dfs(int index)
            {
                if (dp[index] != -1)
                    return dp[index];

                int maxLen = 0;
                for (int i = index + 1; i < nums.Length; i++)
                    if (nums[index] < nums[i])
                        maxLen = Math.Max(maxLen, Dfs(i) + 1);

                return dp[index] = maxLen;
            }
        }
    }
}
