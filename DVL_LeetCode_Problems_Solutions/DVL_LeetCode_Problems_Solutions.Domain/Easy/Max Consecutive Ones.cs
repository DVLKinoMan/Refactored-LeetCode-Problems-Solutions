using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Max Consecutive Ones (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int lastSeenOneIndex = -1, res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1 && lastSeenOneIndex == -1)
                    lastSeenOneIndex = i;
                else if (nums[i] == 0)
                {
                    res = Math.Max(res, lastSeenOneIndex == -1 ? 0 : i - lastSeenOneIndex);
                    lastSeenOneIndex = -1;
                }
            }

            if (lastSeenOneIndex != -1)
                res = Math.Max(res, nums.Length - lastSeenOneIndex);

            return res;
        }
    }
}
