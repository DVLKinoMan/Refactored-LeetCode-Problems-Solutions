using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove_Duplicates_from_Sorted_Array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            var set = new HashSet<int>(nums);
            int i = 0;
            foreach (var s in set.Reverse())
            {
                nums[i] = s;
                i++;
            }

            return set.Count();
        }
    }
}
