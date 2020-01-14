using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Matrix Block Sum (Not Mine)
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int[][] MatrixBlockSum(int[][] mat, int K)
        {
            int m = mat.Length, n = mat[0].Length;
            int[,] sum = new int[m + 1, n + 1]; 
            for (int r = 1; r <= m; r++)
                for (int c = 1; c <= n; c++)
                    sum[r, c] = mat[r - 1][c - 1] + sum[r - 1, c] + sum[r, c - 1] - sum[r - 1, c - 1];

            int[][] ans = new int[m][];
            for (int r = 0; r < m; r++)
            {
                ans[r] = new int[n];
                for (int c = 0; c < n; c++)
                {
                    int r1 = Math.Max(0, r - K), c1 = Math.Max(0, c - K);
                    int r2 = Math.Min(m - 1, r + K), c2 = Math.Min(n - 1, c + K);
                    r1++;
                    c1++;
                    r2++;
                    c2++;
                    ans[r][c] = sum[r2, c2] - sum[r2, c1 - 1] - sum[r1 - 1, c2] + sum[r1 - 1, c1 - 1];
                }
            }

            return ans;
        }
    }
}
