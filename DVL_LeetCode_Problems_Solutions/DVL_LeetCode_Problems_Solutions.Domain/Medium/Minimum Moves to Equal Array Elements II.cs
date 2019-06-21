using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Moves to Equal Array Elements II (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MinMoves2(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            Array.Sort(nums);
            int average = nums[nums.Length / 2];
            int count = 0;
            foreach (var num in nums)
                count+=Math.Abs(num - average);

            return count;
        }
    }
}
