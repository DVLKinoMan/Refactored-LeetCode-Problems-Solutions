using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Sliding Window Maximum (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] rightMax = new int[nums.Length];
            int[] leftMax = new int[nums.Length];
            leftMax[0] = nums[0];
            rightMax[nums.Length - 1] = nums[nums.Length - 1];
            for (int i = 1; i < nums.Length; i++)
            {
                leftMax[i] = i % k == 0 ? nums[i] : Math.Max(leftMax[i - 1], nums[i]);
                int j = nums.Length - i - 1;
                rightMax[j] = j % k == 0 ? nums[j] : Math.Max(rightMax[j + 1], nums[j]);
            }

            var result = new int[nums.Length - k + 1];
            for (int i = 0; i < result.Length; i++)
                result[i] = Math.Max(leftMax[i + k - 1], rightMax[i]);

            return result;
        }
    }
}
