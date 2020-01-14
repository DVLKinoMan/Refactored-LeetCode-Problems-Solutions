using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public int[][] MatrixBlockSum(int[][] mat, int K)
        {
            int m = mat.Length, n = mat[0].Length;
            int[,]
                sum = new int[m + 1,
                    n + 1]; // sum[i][j] is sum of all elements from rectangle (0,0,i,j) as left, top, right, bottom corresponding
            for (int r = 1; r <= m; r++)
                for (int c = 1; c <= n; c++)
                    sum[r, c] = mat[r - 1][c - 1] + sum[r - 1, c] + sum[r, c - 1] - sum[r - 1, c - 1];

            int[,] ans = new int[m, n];
            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    int r1 = Math.Max(0, r - K), c1 = Math.Max(0, c - K);
                    int r2 = Math.Min(m - 1, r + K), c2 = Math.Min(n - 1, c + K);
                    r1++;
                    c1++;
                    r2++;
                    c2++; // Since `sum` start with 1 so we need to increase r1, c1, r2, c2 by 1
                    ans[r, c] = sum[r2, c2] - sum[r2, c1 - 1] - sum[r1 - 1, c2] + sum[r1 - 1, c1 - 1];
                }
            }

            return ans;
        }
    }
}
