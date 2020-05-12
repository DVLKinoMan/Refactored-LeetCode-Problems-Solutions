using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Time to Collect All Apples in a Tree (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="edges"></param>
        /// <param name="hasApple"></param>
        /// <returns></returns>
        public static int MinTime(int n, int[][] edges, IList<bool> hasApple) 
        {
            var dict = new Dictionary<int, List<int>>();
            foreach (var edge in edges)
            {
                if (dict.ContainsKey(edge[0]))
                    dict[edge[0]].Add(edge[1]);
                else dict.Add(edge[0], new List<int>() {edge[1]});
            }

            return Dfs(0).time;

            (bool hasApple, int time) Dfs(int v)
            {
                if (!dict.ContainsKey(v))
                    return (hasApple[v], 0);

                int time = 0;
                foreach (var neighbor in dict[v])
                {
                    var (has, nTime) = Dfs(neighbor);
                    time += has ? nTime + 2 : 0;
                }

                return (time != 0 || hasApple[v], time);
            }
        }
    }
}