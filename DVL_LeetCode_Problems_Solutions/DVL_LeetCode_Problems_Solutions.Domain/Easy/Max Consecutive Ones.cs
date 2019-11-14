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
                switch (nums[i])
                {
                    case 1 when lastSeenOneIndex == -1:
                        lastSeenOneIndex = i;
                        break;
                    case 0:
                        res = Math.Max(res, lastSeenOneIndex == -1 ? 0 : i - lastSeenOneIndex);
                        lastSeenOneIndex = -1;
                        break;
                }
            }

            if (lastSeenOneIndex != -1)
                res = Math.Max(res, nums.Length - lastSeenOneIndex);

            return res;
        }
    }
}
