using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Network Delay Time (Not Working)
        /// </summary>
        /// <param name="times"></param>
        /// <param name="N"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int NetworkDelayTime(int[][] times, int N, int K)
        {
            var visitedSet = new HashSet<int>();
            var dict = new Dictionary<int, List<(int node,int time)>>();
            foreach (var t in times)
            {
                if(dict.ContainsKey(t[0]))
                    dict[t[0]].Add((t[1], t[2]));
                else dict.Add(t[0],new List<(int node, int time)>{(t[1],t[2])});
            }

            int result = Dfs(K);
            return visitedSet.Count == N ? result : -1;

            int Dfs(int node)
            {
                if (visitedSet.Contains(node))
                    return 0;

                visitedSet.Add(node);
                int maxTime = 0;
                if (dict.ContainsKey(node))
                    foreach (var neighbor in dict[node])
                        maxTime = Math.Max(maxTime, neighbor.time + Dfs(neighbor.node));

                return maxTime;
            }
        }
    }
}
