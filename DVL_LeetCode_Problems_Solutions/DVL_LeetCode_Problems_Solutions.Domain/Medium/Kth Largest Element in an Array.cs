using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Kth Largest Element in an Array (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindKthLargest(int[] nums, int k)
        {
            return nums.OrderByDescending(n => n).ElementAt(k - 1);
        }
    }
}
