using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Path Sum
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int MinPathSum(int[][] grid)
        {
            if (grid.Length == 0 || grid[0].Length == 0)
                return 0;

            int m = grid.Length;
            int n = grid[0].Length;
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                grid[i][j] += i - 1 < 0
                    ? (j - 1 < 0 ? 0 : grid[i][j - 1])
                    : (j - 1 < 0 ? grid[i - 1][j] : Math.Min(grid[i - 1][j], grid[i][j - 1]));

            return grid[m - 1][n - 1];
        }
    }
}
