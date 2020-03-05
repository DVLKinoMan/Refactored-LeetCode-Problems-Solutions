using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximal Square (Not Mine)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int MaximalSquare(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return 0;

            int m = matrix.Length, n = matrix[0].Length, result = 0;
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            for (int j = 1; j <= n; j++)
                if (matrix[i - 1][j - 1] == '1')
                {
                    dp[i, j] = Math.Min(Math.Min(dp[i, j - 1], dp[i - 1, j]), dp[i - 1, j - 1]) + 1;
                    result = Math.Max(dp[i, j], result);
                }

            return result * result;
        }
    }
}