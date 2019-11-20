using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Next Greater Element I (Mine)
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var nums2Indexes = new Dictionary<int,int>();
            for (int i = 0; i < nums2.Length; i++)
                nums2Indexes.Add(nums2[i], i);

            var resList = new List<int>();
            foreach (var num in nums1)
            {
                int i = nums2Indexes[num] + 1;
                for ( ;i < nums2.Length; i++)
                    if (nums2[i] > num)
                    {
                        resList.Add(nums2[i]);
                        break;
                    }

                if (i == nums2.Length)
                    resList.Add(-1);
            }

            return resList.ToArray();
        }
    }
}
