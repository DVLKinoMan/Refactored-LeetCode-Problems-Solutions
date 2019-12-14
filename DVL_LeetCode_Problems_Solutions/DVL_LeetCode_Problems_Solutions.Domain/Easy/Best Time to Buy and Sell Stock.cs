using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Best Time to Buy and Sell Stock (Not Mine. Mine worked but was brute force)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            int maxRes = 0, currMax = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                currMax = Math.Max(0, currMax += prices[i] - prices[i - 1]);
                maxRes = Math.Max(maxRes, currMax);
            }

            return maxRes;
        }
    }
}
