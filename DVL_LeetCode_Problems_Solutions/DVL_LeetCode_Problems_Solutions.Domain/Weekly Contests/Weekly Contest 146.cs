using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static int[] ShortestAlternatingPaths(int n, int[][] red_edges, int[][] blue_edges)
        {
            var res = new int[n];
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

            int currNode = 0, height = 0;
            bool redsTurn = true;
            //var listNodes = blue_edgesDic.Where(d=>d.Key == 0).Select(d=>d.)
            while (true)
            {
                if (redsTurn && !red_edgesDic.ContainsKey(currNode))
                    break;
                else if (!redsTurn && !blue_edgesDic.ContainsKey(currNode))
                    break;

                height++;
            }

            return res;
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
