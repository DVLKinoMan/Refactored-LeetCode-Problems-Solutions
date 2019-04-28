using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain.Weekly_Contests
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Moving stones Until Conesecutive (My Solution with Modification)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int[] NumMovesStones(int a, int b, int c)
        {
            int[] arr=new int[]{a,b,c};
            Array.Sort(arr);
            int diff1 = arr[2] - arr[1], diff2 = arr[1] - arr[0];
            if (diff1 == 1 && diff2 == 1)
                return new int[] {0, 0};
            int minMove = diff1 < 3 || diff2 < 3 ? 1 : 2;
            int maxMove = (diff1 - 1) + (diff2 - 1);
            return new int[] {minMove, maxMove};
        }

        /// <summary>
        /// Do not works
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="r0"></param>
        /// <param name="c0"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static int[][] ColorBorder(int[][] grid, int r0, int c0, int color)
        {
            Rec(grid, new int[grid.Length, grid[0].Length], r0, c0, color, grid.Length, grid[0].Length, -1, -1, grid[r0][c0]);
            return grid;
        }

        private static void Rec(int[][] grid, int[,] grid2, int i, int j, int color, int m, int n, int previ, int prevj,
            int prevValue)
        {
            if (grid2[i, j]==-1)
                return;

            grid2[i, j] = -1;

            if (i == 0 || j == 0 || i == m - 1 || j == n - 1)
                grid[i][j] = color;

            if (i-1>=0 && grid[i - 1][j] != prevValue && i - 1 != previ && j != prevj)
                grid[i][j] = color;
            else if (i-1>=0 && i - 1 != previ && j != prevj)
                Rec(grid, grid2, i - 1, j, color, m, n, i, j, prevValue);

            if (i+1<m && grid[i + 1][j] != prevValue && i + 1 != previ && j != prevj)
                grid[i][j] = color;
            else if (i + 1 < m && i + 1 != previ && j != prevj)
                Rec(grid, grid2, i + 1, j, color, m, n, i, j, prevValue);

            if (j-1>=0 && grid[i][j - 1] != prevValue && i != previ && j - 1 != prevj)
                grid[i][j] = color;
            else if (j - 1 >= 0 && i != previ && j - 1 != prevj)
                Rec(grid, grid2, i, j - 1, color, m, n, i, j, prevValue);

            if (j + 1 < n && grid[i][j + 1] != prevValue && i != previ && j + 1 != prevj)
                grid[i][j] = color;
            else if (j + 1 < n && i != previ && j + 1 != prevj)
                Rec(grid, grid2, i, j + 1, color, m, n, i, j, prevValue);
        }

        /// <summary>
        /// Do not works
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int MaxUncrossedLines(int[] A, int[] B)
        {
            int result = 0;
            int i = 0;
            int j = 0;
            int count = 0;
            while (j != B.Length || i!=A.Length)
            {
                if (A[i] == B[j])
                {
                    i++;
                    count++;
                }

                j++;
            }

            return result;
        }
    }
}
