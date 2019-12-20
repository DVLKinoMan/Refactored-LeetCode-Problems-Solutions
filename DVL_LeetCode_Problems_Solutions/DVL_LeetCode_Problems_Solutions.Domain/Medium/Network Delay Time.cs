using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Network Delay Time (Mine)
        /// </summary>
        /// <param name="times"></param>
        /// <param name="N"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int NetworkDelayTime(int[][] times, int N, int K)
        {
            var visited = new Dictionary<int, int>();
            var dict = new Dictionary<int, List<(int node, int time)>>();
            foreach (var t in times)
            {
                if (dict.ContainsKey(t[0]))
                    dict[t[0]].Add((t[1], t[2]));
                else dict.Add(t[0], new List<(int node, int time)> {(t[1], t[2])});
            }

            var nodesList = new List<int> {K};
            visited.Add(K, 0);
            while (nodesList.Count != 0)
            {
                var newList = new List<int>();
                foreach (var node in nodesList)
                    if (dict.ContainsKey(node))
                        foreach (var neighbor in dict[node])
                            if (!visited.ContainsKey(neighbor.node) ||
                                visited[neighbor.node] > visited[node] + neighbor.time)
                            {
                                if (visited.ContainsKey(neighbor.node))
                                    visited[neighbor.node] = visited[node] + neighbor.time;
                                else visited.Add(neighbor.node, visited[node] + neighbor.time);
                                newList.Add(neighbor.node);
                            }

                nodesList = newList;
            }

            return visited.Count == N ? visited.Max(v => v.Value) : -1;
        }
    }
}
