using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find All Duplicates in an Array (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> FindDuplicates(int[] nums)
        {
            var set = new HashSet<int>();
            return nums.Where(num => !set.Add(num)).ToList();
        }
    }
}
