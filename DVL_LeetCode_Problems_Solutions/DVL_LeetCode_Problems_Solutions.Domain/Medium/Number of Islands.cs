using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Islands (Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int m = grid.Length, n = grid[0].Length, count = 0;
            var set = new HashSet<(int, int)>();
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (!set.Contains((i, j)) && grid[i][j] == '1')
                {
                    Dfs(i, j);
                    count++;
                }

            return count;

            void Dfs(int i, int j)
            {
                if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] == '0' || set.Contains((i, j)))
                    return;
                set.Add((i, j));
                Dfs(i + 1, j);
                Dfs(i, j + 1);
                Dfs(i - 1, j);
                Dfs(i, j - 1);
            }
        }
    }
}
