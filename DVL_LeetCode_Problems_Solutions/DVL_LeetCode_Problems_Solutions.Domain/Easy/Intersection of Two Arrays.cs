using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Intersection of Two Arrays (Mine)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var set = new HashSet<int>(nums1);
            return nums2.Where(n => set.Contains(n)).Distinct().ToArray();
        }
    }
}
