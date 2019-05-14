using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {

        /// <summary>
        /// Robot Bounded In Circle (Not Works)
        /// </summary>
        /// <param name="instructions"></param>
        /// <returns></returns>
        public static bool IsRobotBounded(string instructions)
        {
            if (!instructions.Contains('G'))
                return true;

            int[] arr = new int[] {0, 1, 2, 3};
            int d = 0, i = 0;

            while (i < instructions.Length)
            {
                if (instructions[i] == 'L')
                {
                    if (d + 1 == arr.Length)
                        d = 0;
                    else d++;
                }
                else if (instructions[i] == 'R')
                {
                    if (d - 1 < 0)
                        d = arr.Length - 1;
                    else d--;
                }

                i++;
            }

            return 0 == arr[d];
        }

        /// <summary>
        /// Robot Bounded In Circle (Not mine)
        /// </summary>
        /// <param name="instructions"></param>
        /// <returns></returns>
        public static bool IsRobotBounded2(string instructions)
        {
            int x = 0, y = 0, i = 0;
            int[][] d = new int[][]{new int[] {0, 1}, new int[] { 1, 0}, new int[] { 0, -1}, new int[] { -1, 0}};
            for (int j = 0; j< instructions.Length; ++j)
                if (instructions[j] == 'R')
                    i = (i + 1) % 4;
                else if (instructions[j] == 'L')
                    i = (i + 3) % 4;
                else {
                    x += d[i][0]; y += d[i][1];
                }
            return x == 0 && y == 0 || i > 0;
        }

        /// <summary>
        /// Flower Planting With No Adjacent (My Solution)
        /// </summary>
        /// <param name="N"></param>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static int[] GardenNoAdj(int N, int[][] paths)
        {
            int[] res = new int[N];
            int[] colors=new int[]{1,2,3,4};
            var dic = new Dictionary<int, List<int>>();
            foreach (var path in paths)
            {
                if (dic.ContainsKey(path[0]))
                    dic[path[0]].Add(path[1]);
                else dic.Add(path[0], new List<int> {path[1]});

                if (dic.ContainsKey(path[1]))
                    dic[path[1]].Add(path[0]);
                else dic.Add(path[1], new List<int> { path[0] });
            }

            foreach (var d in dic)
            {
                if (res[d.Key - 1] == 0)
                {
                    res[d.Key - 1] = 1;
                    GardenNoAdjDFS(d.Key, dic, colors, res);
                }
            }

            for (int i = 0; i < res.Length; i++)
                if (res[i] == 0)
                    res[i] = 1;

            return res;
        }

        public static void GardenNoAdjDFS(int garden, Dictionary<int, List<int>> dic, int[] colors, int[] answers)
        {
            if (!dic.ContainsKey(garden))
            {
                answers[garden - 1] = colors[0];
                return;
            }

           var k = dic[garden].Where(v => answers[v - 1] != 0).Select(v => answers[v - 1]);
           answers[garden - 1] = colors.First(c => !k.Contains(c));
           foreach (var gard in dic[garden])
               if (answers[gard - 1] == 0)
               GardenNoAdjDFS(gard, dic, colors, answers);
        }

        /// <summary>
        /// Partition Array for Maximum Sum (Almost Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int MaxSumAfterPartitioning(int[] A, int K)
        {
            int[] dp=new int[A.Length];
            for (int i = 0; i < dp.Length; i++)
            {
                int currMax = 0;
                for (int j = 0; j < K && i - j>=0; j++)
                {
                    currMax = Math.Max(currMax, A[i - j]);
                    dp[i] = Math.Max(dp[i], (i - j - 1 >= 0 ? dp[i - j - 1] : 0) + currMax * (j + 1));
                }
            }

            return dp[A.Length - 1];
        }
    }
}
