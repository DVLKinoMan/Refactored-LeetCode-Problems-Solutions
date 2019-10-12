using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Max Increase to Keep City Skyline (Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            int[] topOrBottom = grid.SelectMany(g => g.Select((el, j) => (el, j)))
                                    .GroupBy(t => t.j)
                                    .Select(gr => gr.Select(g=>g.el).Max())
                                    .ToArray();
            int[] leftOrRight = grid.Select(row => row.Max()).ToArray();

            int count = 0;
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                count += Math.Min(topOrBottom[i], leftOrRight[j]) - grid[i][j];

            return count;
        }
    }
}
