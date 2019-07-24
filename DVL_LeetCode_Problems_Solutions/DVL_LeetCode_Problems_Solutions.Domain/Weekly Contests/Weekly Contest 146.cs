using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int NumEquivDominoPairs(int[][] dominoes)
        {
            var dic = new Dictionary<(int,int), int>();

            foreach (var domino in dominoes)
            {
                if(dic.ContainsKey((domino[0], domino[1])))
                dic[(domino[0], domino[1])]++;
                else if (dic.ContainsKey((domino[1], domino[0])))
                dic[(domino[1], domino[0])]++;
                else
                    dic.Add((domino[0],domino[1]),1);
            }

            return dic.Where(d => d.Value > 1).Select(d =>
            {
                int sum = 0;
                for (int i = d.Value - 1; i > 0; i--)
                    sum += i;
                return sum;
            }).Sum();
        }

        /// <summary>
        /// Shortest Path with Alternating Colors (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="red_edges"></param>
        /// <param name="blue_edges"></param>
        /// <returns></returns>
        public static int[] ShortestAlternatingPaths(int n, int[][] red_edges, int[][] blue_edges)
        {
            var answer = new int[n];
            var red_edgesDic = new Dictionary<int, List<int>>();
            var blue_edgesDic = new Dictionary<int, List<int>>();

            foreach (var red_edge in red_edges)
                if (red_edgesDic.ContainsKey(red_edge[0]))
                    red_edgesDic[red_edge[0]].Add(red_edge[1]);
                else
                    red_edgesDic.Add(red_edge[0], new List<int>() {red_edge[1]});

            foreach (var blue_edge in blue_edges)
                if (blue_edgesDic.ContainsKey(blue_edge[0]))
                    blue_edgesDic[blue_edge[0]].Add(blue_edge[1]);
                else
                    blue_edgesDic.Add(blue_edge[0], new List<int>() {blue_edge[1]});

            var openedList = new List<(int number, bool redsTrun, int distance)> { (0,true, 0), (0, false, 0) };
            var closedList = new List<(int number, bool redsTrun, int distance)>();
            while (openedList.Count != 0)
            {
                var currNode = openedList[0];
                var nodes = currNode.redsTrun && red_edgesDic.ContainsKey(currNode.number) ? red_edgesDic[currNode.number] :
                    (!currNode.redsTrun && blue_edgesDic.ContainsKey(currNode.number) ? blue_edgesDic[currNode.number] : new List<int>());
                foreach (var node in nodes)
                {
                    (int number, bool redsTrun, int distance) node2 = (node, !currNode.redsTrun, currNode.distance + 1);
                    if (node2.distance < answer[node2.number] || answer[node2.number] == 0)
                        answer[node2.number] = node2.distance;
                    if (!closedList.Any(d=>d.number == node2.number && d.redsTrun == node2.redsTrun))
                        openedList.Add(node2);
                }
                openedList.RemoveAt(0);
                closedList.Add(currNode);
            }

            for(int i=1;i<answer.Length;i++)
                if (answer[i] == 0)
                    answer[i] = -1;

            return answer;
        }

        /// <summary>
        /// Minimum Cost Tree From Leaf Values (Not Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int MctFromLeafValues(int[] arr)
        {
            int res = 0;
            var stack = new Stack<int>();
            stack.Push(int.MaxValue);
            foreach (var a in arr)
            {
                while (stack.Peek() <= a)
                {
                    int mid = stack.Pop();
                    res += mid * Math.Min(stack.Peek(), a);
                }
                stack.Push(a);
            }
            while (stack.Count > 2)
                res += stack.Pop() * stack.Peek();

            return res;
        }
    }
}
