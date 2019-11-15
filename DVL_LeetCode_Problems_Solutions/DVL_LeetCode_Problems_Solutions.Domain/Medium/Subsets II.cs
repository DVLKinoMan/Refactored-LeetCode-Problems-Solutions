using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Subsets II (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var list = new List<IList<int>>();
            Array.Sort(nums);
            BackTrack(list, new List<int>(), nums, 0);
            return list;

            void BackTrack(IList<IList<int>> l, List<int> list2, int[] nums2, int index)
            {
                l.Add(new List<int>(list2));
                for (int i = index; i < nums2.Length; i++)
                {
                    if (i > index && nums2[i] == nums2[i - 1])
                        continue;
                    list2.Add(nums2[i]);
                    BackTrack(l, list2, nums2, i + 1);
                    list2.RemoveAt(list2.Count - 1);
                }
            }
        }
    }
}
