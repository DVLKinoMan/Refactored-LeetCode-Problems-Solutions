using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int ArrayPairSum(int[] nums)
        {
            int result = 0;
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i+=2)
                result += nums[i];

            return result;
        }
    }
}
