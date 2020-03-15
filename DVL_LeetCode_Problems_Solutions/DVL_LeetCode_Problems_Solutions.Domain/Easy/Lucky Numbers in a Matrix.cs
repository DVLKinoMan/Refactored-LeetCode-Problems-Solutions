using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Lucky Numbers in a Matrix (Mine)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            var result = new List<int>();
            int n = matrix.Length, m = matrix[0].Length;
            int[] colsMax = new int[m], rowsMin = Enumerable.Repeat(int.MaxValue, n).ToArray();

            for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                colsMax[j] = Math.Max(colsMax[j], matrix[i][j]);
                rowsMin[i] = Math.Min(rowsMin[i], matrix[i][j]);
            }

            for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (matrix[i][j] == rowsMin[i] && matrix[i][j] == colsMax[j])
                {
                    result.Add(matrix[i][j]);
                    break;
                }

            return result;
        }
    }
}