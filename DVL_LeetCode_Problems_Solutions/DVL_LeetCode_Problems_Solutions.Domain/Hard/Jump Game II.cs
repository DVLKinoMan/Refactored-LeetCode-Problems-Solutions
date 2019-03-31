using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Jump Game II (Not mine Solution, but Typed I)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Jump(int[] nums)
        {
            int res = 0, max = 0, i2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                max = Math.Max(max, nums[i] + i);
                if (i2 == i)
                {
                    res++;
                    i2 = max;
                }
            }

            return res;
        }

        //public static int Jump(int[] nums)
        //{
        //    return nums.Length == 0 ? 0 : MinStepsInJump(nums, 0);
        //}

        //private static int MinStepsInJump(int[] nums, int i)
        //{
        //    if (i == nums.Length - 1)
        //        return 0;

        //    int min = nums.Length - i - 1;
        //    int lastIndex = nums[i] + i >= nums.Length ? nums.Length - 1 : nums[i] + i;
        //    for (int i2 = i + 1; i2 <= lastIndex; i2++)
        //    {
        //        int res = MinStepsInJump(nums, i2) + 1;
        //        if (min > res)
        //            min = res;
        //    }

        //    return min;
        //}
    }
}
