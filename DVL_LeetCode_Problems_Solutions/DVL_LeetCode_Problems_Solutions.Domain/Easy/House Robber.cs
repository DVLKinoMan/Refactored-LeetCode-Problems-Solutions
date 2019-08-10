using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// House Robber (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Rob(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int prev1 = 0, prev2 = 0;
            foreach (int num in nums)
            {
                int tmp = prev1;
                prev1 = Math.Max(prev2 + num, prev1);
                prev2 = tmp;
            }
            return prev1;
        }
    }
}
