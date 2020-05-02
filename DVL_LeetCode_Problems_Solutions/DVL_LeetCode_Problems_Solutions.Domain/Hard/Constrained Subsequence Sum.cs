using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Constrained Subsequence Sum (Almost Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int ConstrainedSubsetSum(int[] nums, int k) 
        {
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            int currentMaxIndex = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (j - currentMaxIndex > k)
                {
                    currentMaxIndex = j - 1;
                    for (int i = j - 2; i >= 0 && j - i <= k; i--)
                        if (dp[currentMaxIndex] < dp[i])
                            currentMaxIndex = i;
                }

                dp[j] = Math.Max(nums[j], nums[j] + dp[currentMaxIndex]);

                if (dp[currentMaxIndex] < dp[j])
                    currentMaxIndex = j;
            }

            return dp.Max();
        }
    }
}