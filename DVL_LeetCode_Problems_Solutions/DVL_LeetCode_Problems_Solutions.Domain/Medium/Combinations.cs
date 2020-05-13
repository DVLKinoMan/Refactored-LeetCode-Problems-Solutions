using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Combinations (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IList<IList<int>> Combine(int n, int k)
        {
            var result = new List<IList<int>>();
            Dfs(1, new List<int>());
            return result;

            void Dfs(int j, List<int> list)
            {
                if (list.Count == k)
                {
                    result.Add(list.ToList());
                    return;
                }

                for (int i = j; i <= n; i++)
                {
                    list.Add(i);
                    Dfs(i + 1, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}