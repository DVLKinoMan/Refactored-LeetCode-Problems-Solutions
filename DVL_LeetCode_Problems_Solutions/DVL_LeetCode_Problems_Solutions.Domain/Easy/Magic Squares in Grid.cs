namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Magic Squares In Grid (Not Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int NumMagicSquaresInside(int[][] grid)
        {
            int res = 0;
            for (int i = 1; i < grid.Length - 1; i++)
            for (int j = 1; j < grid[0].Length - 1; j++)
                if (grid[i][j] == 5)
                    res += isMagic(i, j, grid) ? 1 : 0;

            bool isMagic(int i, int j, int[][] grid)
            {
                string s = "" + grid[i - 1][j - 1] + grid[i - 1][j] + grid[i - 1][j + 1] + grid[i][j + 1] +
                           grid[i + 1][j + 1] +
                           grid[i + 1][j] + grid[i + 1][j - 1] + grid[i][j - 1];
                return "4381672943816729".Contains(s) || "9276183492761834".Contains(s);
            }

            return res;
        }
    }
}
