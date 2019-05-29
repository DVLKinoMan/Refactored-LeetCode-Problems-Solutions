using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Third Maximum Number (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int ThirdMax(int[] nums)
        {
            nums = nums.OrderByDescending(n=>n).Distinct().ToArray();
            if (nums.Length < 3)
                return nums[0];

            return nums[2];
        }
    }
}
