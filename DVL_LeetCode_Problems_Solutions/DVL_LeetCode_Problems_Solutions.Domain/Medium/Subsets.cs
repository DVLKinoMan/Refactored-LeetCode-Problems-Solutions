using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Subsets (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> Subsets(int[] nums)
        {
            var res = new List<IList<int>>();
            BackTrack(res, nums, new List<int>(), 0);
            return res;

            void BackTrack(IList<IList<int>> res2, int[] nums2, List<int> l, int index)
            {
                res2.Add(new List<int>(l));
                for (int i = index; i < nums2.Length; i++)
                {
                    l.Add(nums2[i]);
                    BackTrack(res2, nums2, l, i + 1);
                    l.RemoveAt(l.Count - 1);
                }
            }
        }
    }
}
