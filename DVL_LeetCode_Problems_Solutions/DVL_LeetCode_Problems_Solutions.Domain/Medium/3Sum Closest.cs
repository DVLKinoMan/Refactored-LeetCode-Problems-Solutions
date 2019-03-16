using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// _3Sum_Closest
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int ThreeSumClosest(int[] nums, int target)
        {
            if (nums.Length < 3)
                return 0;

            Array.Sort(nums);
            int result = nums.Take(3).Sum();
            for (int i = 0; i < nums.Length; i++)
            {
                int begin = i + 1, end = nums.Length - 1;
                while (begin < end)
                {
                    int sum = nums[i] + nums[begin] + nums[end];
                    if (Math.Abs(result - target) > Math.Abs(sum - target))
                        result = sum;

                    if (result == target)
                        return result;

                    if (sum < target)
                        begin++;
                    else
                        end--;
                }
            }

            return result;
        }
    }
}
