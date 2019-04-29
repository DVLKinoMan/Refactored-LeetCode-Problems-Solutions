using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Matrix Cells in Distance Order (My solution)
        /// </summary>
        /// <param name="R"></param>
        /// <param name="C"></param>
        /// <param name="r0"></param>
        /// <param name="c0"></param>
        /// <returns></returns>
        public static int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {

            int[][] matrix = new int[R * C][];
            var dic = new Dictionary<int, List<int[]>>();
            for (int i = 0; i < R; i++)
            for (int j = 0; j < C; j++)
            {
                int distance = Math.Abs(i - r0) + Math.Abs(j - c0);
                if (dic.ContainsKey(distance))
                    dic[distance].Add(new int[] {i, j});
                else dic.Add(distance, new List<int[]>() {new int[] {i, j}});
            }

            int count = 0;
            foreach (var d in dic.OrderBy(d=>d.Key))
            foreach (var arr in d.Value)
            {
                matrix[count] = arr;
                count++;
            }

            return matrix;
        }

        /// <summary>
        /// Two City Scheduling (Not Mine Solution)
        /// </summary>
        /// <param name="costs"></param>
        /// <returns></returns>
        public static int TwoCitySchedCost(int[][] costs)
        {
            int N = costs.Length / 2;
            int[][] dp = new int[N + 1][];

            for (int i = 1; i <= N; i++)
            {
                dp[i] = new int[N + 1];
                dp[i][0] = dp[i - 1][0] + costs[i - 1][0];
            }

            for (int j = 1; j <= N; j++)
                dp[0][j] = dp[0][j - 1] + costs[j - 1][1];

            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= N; j++)
                    dp[i][j] = Math.Min(dp[i - 1][j] + costs[i + j - 1][0], dp[i][j - 1] + costs[i + j - 1][1]);
              

            return dp[N][N];
        }
    }

    /// <summary>
    /// Do not Works
    /// </summary>
    public class StreamChecker
    {
        private int[] wordsIndexes;
        private string[] words;

        public StreamChecker(string[] words)
        {
            wordsIndexes = new int[words.Length];
            this.words = words;
        }

        public bool Query(char letter)
        {
            bool result = false;
            for(int i=0; i<wordsIndexes.Length;i++)
                if (wordsIndexes[i] != words[i].Length && words[i][wordsIndexes[i]] == letter)
                {
                    wordsIndexes[i]++;
                    if (wordsIndexes[i] == words[i].Length)
                        result = true;
                }
                else if (wordsIndexes[i] == words[i].Length && words[i][wordsIndexes[i] - 1] == letter)
                    result = true;

            return result;
        }
    }
}
