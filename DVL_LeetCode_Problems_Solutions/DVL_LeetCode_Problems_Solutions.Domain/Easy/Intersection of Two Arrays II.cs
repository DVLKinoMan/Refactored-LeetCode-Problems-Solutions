using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Intersection of Two Arrays II (Mine)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var list = new List<int>();
            var dict = new Dictionary<int, int>();
            foreach (var num in nums1)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else dict.Add(num, 1);
            }

            foreach (var num in nums2)
            {
                if (dict.ContainsKey(num) && dict[num] != 0)
                {
                    dict[num]--;
                    list.Add(num);
                }
            }

            return list.ToArray();
        }
    }
}
