using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Critical Connections in a Network (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="connections"></param>
        /// <returns></returns>
        public static IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
        {
            var dic = new Dictionary<int, List<int>>();
            foreach (var connection in connections)
            {
                if (dic.ContainsKey(connection[0]))
                    dic[connection[0]].Add(connection[1]);
                else dic.Add(connection[0], new List<int> { connection[1] });
                if (dic.ContainsKey(connection[1]))
                    dic[connection[1]].Add(connection[0]);
                else dic.Add(connection[1], new List<int> { connection[0] });
            }

            int[] rank = new int[dic.Count];
            for (int i = 0; i < rank.Length; i++)
                rank[i] = -2;

            var conns = new Dictionary<(int, int), int>();
            int dfs(int node, int depth)
            {
                if (rank[node] >= 0)
                    return rank[node];

                rank[node] = depth;
                int min = n;
                foreach (var neighbor in dic[node])
                {
                    if (rank[neighbor] == depth - 1)
                        continue;
                    int back_depth = dfs(neighbor, depth + 1);
                    if (back_depth <= depth)
                        conns.Add((node, neighbor), 1);
                    min = Math.Min(min, back_depth);
                }

                return min;
            }
            dfs(0, 0);

            var res = new List<IList<int>>();
            foreach (var conn in connections)
                if (!conns.ContainsKey((conn[0], conn[1])) && !conns.ContainsKey((conn[1], conn[0])))
                    res.Add(conn);

            return res;
        }
    }
}
