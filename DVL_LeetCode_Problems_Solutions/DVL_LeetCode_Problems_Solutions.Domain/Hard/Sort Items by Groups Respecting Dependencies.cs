﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Hard
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sort Items by Groups Respecting Dependencies (Not Mine - my implemntation)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="group"></param>
        /// <param name="beforeItems"></param>
        /// <returns></returns>
        public static int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
        {
            var itemGraph = new ConcurrentDictionary<int, HashSet<int>>();
            var itemInDegree = new ConcurrentDictionary<int, int>();

            for (int i = 0; i < n; i++)
                itemGraph.TryAdd(i, new HashSet<int>());

            var groupGraph = new ConcurrentDictionary<int, HashSet<int>>();
            var groupInDegree = new ConcurrentDictionary<int, int>();

            foreach (int g in group)
                groupGraph.TryAdd(g, new HashSet<int>());

            for (int i = 0; i < beforeItems.Count; i++)
                if (beforeItems[i].Count != 0)
                    foreach (var val in beforeItems[i])
                    {
                        itemGraph[val].Add(i);
                        if (!itemInDegree.TryAdd(i, 1))
                            itemInDegree[i]++;

                        int g1 = group[val], g2 = group[i];
                        if (g1 != g2 && groupGraph[g1].Add(g2))
                            if (!groupInDegree.TryAdd(g2, 1))
                                groupInDegree[g2]++;
                    }

            var itemOrdering = topologicalSort(itemGraph, itemInDegree, n);
            var groupOrdering = topologicalSort(groupGraph, groupInDegree, groupGraph.Count);

            if (itemOrdering.Count == 0 || groupOrdering.Count == 0)
                return Array.Empty<int>();

            var map = new Dictionary<int, List<int>>();

            foreach (int item in itemOrdering)
            {
                int g = group[item];
                if (!map.ContainsKey(g))
                    map[g] = new List<int>();
                map[g].Add(item);
            }

            int[] res = new int[n];
            int k = 0;
            foreach (int item in groupOrdering.SelectMany(gr => map[gr]))
            {
                res[k] = item;
                k++;
            }

            return res;

            List<int> topologicalSort(ConcurrentDictionary<int, HashSet<int>> graph,
                                                          ConcurrentDictionary<int, int> inDegree, int count)
            {
                var result = new List<int>();
                var queue = new Queue<int>();
                foreach (int key in graph.Keys)
                    if (!inDegree.ContainsKey(key) || inDegree[key] == 0)
                        queue.Enqueue(key);

                while (queue.Count != 0)
                {
                    int pop = queue.Dequeue();
                    count--;
                    result.Add(pop);
                    foreach (var next in graph[pop])
                    {
                        int val = inDegree[next];
                        if (!inDegree.TryAdd(next, val - 1))
                            inDegree[next] = val - 1;
                        if (inDegree[next] == 0)
                            queue.Enqueue(next);
                    }
                }

                return count == 0 ? result : new List<int>();
            }
        }
    }
}
