using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Merge Sorted Array
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var res = new List<int>();
            int i = 0, j = 0;
            while (i != m || j != n)
            {
                if (i == m)
                    res.Add(nums2[j++]);
                else if (j == n)
                    res.Add(nums1[i++]);
                else
                {
                    if (nums1[i] < nums2[j])
                        res.Add(nums1[i++]);
                    else res.Add(nums2[j++]);
                }
            }

            for (int i2 = 0; i2 < res.Count; i2++)
                nums1[i2] = res[i2];
        }
    }
}
