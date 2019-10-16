using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// All Paths From Source to Target (Mine)
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            int n = graph.Length;
            var res = new List<IList<int>>();
            Dfs(0, new List<int>() {0});
            return res;

            bool Dfs(int index, List<int> list)
            {
                if (index == n - 1)
                    return true;

                foreach (var neighbor in graph[index])
                {
                    list.Add(neighbor);
                    if(Dfs(neighbor, list))
                        res.Add(list.ToList());
                    list.RemoveAt(list.Count - 1);
                }

                return false;
            }
        }
    }
}
