namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rotting Oranges (Not Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int OrangesRotting(int[][] grid)
        {
            int fresh = 0, d = 0;
            for (int i = 0; i < grid.Length; ++i)
            for (int j = 0; j < grid[i].Length; ++j)
                if (grid[i][j] == 1) 
                    fresh++;
            
            for (int old_fresh = fresh; fresh > 0; ++d, old_fresh = fresh) {
                for (int i = 0; i < grid.Length; ++i)
                for (int j = 0; j < grid[i].Length; ++j)
                    if (grid[i][j] == d + 2)
                        fresh -= rot(grid, i + 1, j, d) + rot(grid, i - 1, j, d) + rot(grid, i, j + 1, d) + rot(grid, i, j - 1, d);
                if (fresh == old_fresh) return -1;
            }
            
            return d;

            int rot(int[][] g, int i, int j, int de)
            {
                if (i < 0 || j < 0 || i >= g.Length || j >= g[i].Length || g[i][j] != 1) return 0;
                g[i][j] = de + 3;
                return 1;
            }
        }
    }
}