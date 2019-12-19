using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Max Area of Island (Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int MaxAreaOfIsland(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            var visitedSet = new HashSet<(int, int)>();
            int maxArea = 0;

            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (grid[i][j] == 1 && !visitedSet.Contains((i, j)))
                    maxArea = Math.Max(maxArea, Dfs(i, j));

            return maxArea;

            int Dfs(int row, int col, int count = 1)
            {
                if (row >= m || row < 0 || col < 0 || col >= n || grid[row][col] == 0 ||
                    visitedSet.Contains((row, col)))
                    return 0;
                visitedSet.Add((row, col));
                count += Dfs(row + 1, col);
                count += Dfs(row - 1, col);
                count += Dfs(row, col - 1);
                count += Dfs(row, col + 1);

                return count;
            }
        }
    }
}
