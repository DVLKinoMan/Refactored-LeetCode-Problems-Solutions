using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Average Subarray I (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static double FindMaxAverage(int[] nums, int k)
        {
            int currSum = nums.Take(k).Sum();
            double max =  currSum / (double)k;
            for (int i = k; i < nums.Length; i++)
            {
                currSum -= nums[i - k];
                currSum += nums[i];
                max = Math.Max(max, currSum / (double) k);
            }

            return max;
        }
    }
}
