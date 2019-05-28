using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Minimum in Rotated Sorted Array II (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMin(int[] nums)
        {
            nums = nums.Distinct().ToArray();
            int start = 0, end = nums.Length - 1;
            if (nums.Length == 1 || nums[start] < nums[end])
                return nums[start];

            int middle = 0;
            while (start <= end)
            {
                middle = (start + end) / 2;
                if (nums[0] <= nums[middle])
                    start = middle + 1;
                else
                    end = middle - 1;
            }

            return nums[start >= nums.Length ? nums.Length - 1 : start];
        }
    }
}
