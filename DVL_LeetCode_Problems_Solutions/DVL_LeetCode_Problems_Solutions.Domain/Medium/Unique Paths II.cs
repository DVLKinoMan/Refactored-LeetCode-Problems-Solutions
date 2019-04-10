namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Unique Paths II (My Solution)
        /// </summary>
        /// <param name="obstacleGrid"></param>
        /// <returns></returns>
        public static int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid.Length == 0)
                return 0;

            int m = obstacleGrid.Length, n = obstacleGrid[0].Length;
            var matrix = new int[m, n];
            bool obstacles = false;
            for (int i = 0; i < m; i++)
                if (obstacles || obstacleGrid[i][0] == 1)
                {
                    obstacles = true;
                    matrix[i, 0] = 0;
                }
                else
                    matrix[i, 0] = 1;

            obstacles = false;
            for (int j = 0; j < n; j++)
                if (obstacles || obstacleGrid[0][j] == 1)
                {
                    obstacles = true;
                    matrix[0, j] = 0;
                }
                else
                    matrix[0, j] = 1;

            for (int i = 1; i < m; i++)
            for (int j = 1; j < n; j++)
            {
                if (obstacleGrid[i][j] == 1)
                    matrix[i, j] = 0;
                else
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }

            return matrix[m - 1, n - 1];
        }
    }
}
