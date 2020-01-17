using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Product of Three Numbers (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int product1 = 1;
            for (int i = nums.Length - 3; i < nums.Length; i++)
                product1 *= nums[i];
            int product2 = nums[0] * nums[1] * nums[nums.Length - 1];
            return Math.Max(product1, product2);
        }
    }
}
