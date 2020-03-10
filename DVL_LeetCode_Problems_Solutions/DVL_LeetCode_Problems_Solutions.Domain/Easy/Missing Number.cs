using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Missing Number (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MissingNumber(int[] nums)
        {
            var set = new HashSet<int>(Enumerable.Range(0, nums.Length + 1));
            foreach (var num in nums)
                set.Remove(num);
            return set.First();
        }
    }
}