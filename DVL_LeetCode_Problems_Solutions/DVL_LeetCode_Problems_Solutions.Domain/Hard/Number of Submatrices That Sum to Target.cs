using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Submatrices That Sum to Target (Not Mine)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int NumSubmatrixSumTarget(int[][] matrix, int target)
        {
            int m = matrix.Length, n = matrix[0].Length;
            for (int i = 0; i < m; i++)
            for (int j = 1; j < n; j++)
                matrix[i][j] += matrix[i][j - 1];

            int res = 0;
            for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                var counter = new Dictionary<int, int>();
                counter.Add(0, 1);
                int cur = 0;
                for (int k = 0; k < m; k++)
                {
                    cur += matrix[k][j] - (i > 0 ? matrix[k][i - 1] : 0);
                    res += counter.ContainsKey(cur - target) ? counter[cur - target] : 0;
                    if (counter.ContainsKey(cur))
                        counter[cur]++;
                    else counter.Add(cur, 1);
                }
            }

            return res;
        }
    }
}
