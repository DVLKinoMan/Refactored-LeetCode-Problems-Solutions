using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Falling Path Sum (Mine and Not mine faster version)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MinFallingPathSum(int[][] A)
        {
            //My version:
            // int n = A.Length, m = A[0].Length, result = int.MaxValue;
            // var dict = new Dictionary<(int, int), int>();
            // for (int i = 0; i < m; i++)
            //     result = Math.Min(result, Dfs(0,i));   
            //
            // return result;
            //
            // int Dfs(int row, int column)
            // {
            //     if (row == n)
            //         return 0;
            //     
            //     if (dict.ContainsKey((row, column)))
            //         return dict[(row, column)];
            //     
            //     int min = int.MaxValue;
            //     if (column < m)
            //         min = Math.Min(min, Dfs(row + 1, column) + A[row][column]);
            //     if (column + 1 < m)
            //         min = Math.Min(min, Dfs(row + 1, column + 1) + A[row][column + 1]);
            //     if (column - 1 >= 0)
            //         min = Math.Min(min, Dfs(row + 1, column - 1) + A[row][column - 1]);
            //
            //     return dict[(row, column)] = min;
            // }

            //Not Mine:
            int result = 0;
            for (int row = A.Length - 2; row >= 0; row--)
            for (int col = 0; col < A[row].Length; col++)
            {
                int best = A[row + 1][col];
                if (col > 0)
                    best = Math.Min(best, A[row + 1][col - 1]);
                if (col < A[row].Length - 1)
                    best = Math.Min(best, A[row + 1][col + 1]);
                A[row][col] += best;
            }

            return A[0].Min();
        }
    }
}