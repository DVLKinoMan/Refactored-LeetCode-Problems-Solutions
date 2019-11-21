using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Increasing Subsequences (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> FindSubsequences(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Dfs(new List<int>(), 0);
            return res;

            void Dfs(List<int> list, int currIndex)
            {
                var set = new HashSet<int>();
                for (int i = currIndex; i < nums.Length; i++)
                {
                    if ((list.Count > 0 && list[list.Count - 1] > nums[i]) || set.Contains(nums[i]))
                        continue;
                    set.Add(nums[i]);
                    list.Add(nums[i]);
                    if (list.Count != 1)
                        res.Add(list.ToList());
                    Dfs(list, i + 1);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}
