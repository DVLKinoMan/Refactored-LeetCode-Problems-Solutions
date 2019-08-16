namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Island Perimeter (Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int IslandPerimeter(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length, perimeter = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (grid[i][j] == 1)
                    {
                        if (j == 0 || grid[i][j - 1] == 0)
                            perimeter++;
                        if (i == 0 || grid[i - 1][j] == 0)
                            perimeter++;
                        if (j == n - 1 || grid[i][j + 1] == 0)
                            perimeter++;
                        if (i == m - 1 || grid[i + 1][j] == 0)
                            perimeter++;
                    }

            return perimeter;
        }
    }
}
