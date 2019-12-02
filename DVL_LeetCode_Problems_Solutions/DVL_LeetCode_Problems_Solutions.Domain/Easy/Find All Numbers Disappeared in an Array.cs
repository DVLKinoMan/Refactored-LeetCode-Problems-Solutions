using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find All Numbers Disappeared in an Array (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var set = new HashSet<int>(Enumerable.Range(1, nums.Length));
            foreach (var num in nums)
                set.Remove(num);

            return set.ToList();
        }
    }
}
