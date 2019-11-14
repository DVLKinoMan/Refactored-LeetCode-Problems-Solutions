using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid Triangle Number (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int TriangleNumber(int[] nums)
        {
            Array.Sort(nums);
            int count = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            for (int j = i + 1; j < nums.Length - 1; j++)
            for (int k = j + 1; k < nums.Length; k++)
            {
                if (nums[i] + nums[j] <= nums[k])
                    break;
                count++;
            }

            return count;
        }
    }
}
