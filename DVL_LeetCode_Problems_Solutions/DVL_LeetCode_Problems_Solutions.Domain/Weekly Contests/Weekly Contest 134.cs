using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
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
        /// Coloring a Border
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="r0"></param>
        /// <param name="c0"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static int[][] ColorBorder(int[][] grid, int r0, int c0, int color)
        {
            var resGrid = new int[grid.Length][];
            for (int i = 0; i < grid.Length; i++)
            {
                resGrid[i]=new int[grid[i].Length];
                for (int j = 0; j < grid[i].Length; j++)
                    resGrid[i][j] = grid[i][j];
            }
            ColorBorderHelper(grid, resGrid,  new bool[grid.Length, grid[0].Length], r0, c0, color,  grid[r0][c0]);
            return resGrid;
        }

        private static void ColorBorderHelper(int[][] grid, int[][] resGrid, bool[,] grid2, int i, int j, int color, int value)
        {
            grid2[i, j] = true;
            bool isBorder = false;

            if (i == 0 || j == 0 || i == grid.Length - 1 || j == grid[0].Length - 1)
                isBorder = true;

            if (i - 1 >= 0)
            {
                if (grid[i - 1][j] != value)
                    isBorder = true;
                else if (!grid2[i-1,j])
                    ColorBorderHelper(grid, resGrid, grid2, i - 1, j, color, value);
            }

            if (i + 1 < grid.Length)
            {
                if (grid[i + 1][j] != value)
                    isBorder = true;
                else if (!grid2[i + 1,j])
                    ColorBorderHelper(grid, resGrid, grid2, i + 1, j, color, value);
            }

            if (j - 1 >= 0)
            {
                if (grid[i][j - 1] != value)
                    isBorder = true;
                else if (!grid2[i,j-1])
                    ColorBorderHelper(grid, resGrid, grid2, i, j - 1, color, value);
            }

            if (j + 1 < grid[0].Length)
            {
                if (grid[i][j + 1] != value)
                    isBorder = true;
                else if (!grid2[i, j + 1])
                    ColorBorderHelper(grid, resGrid, grid2, i, j + 1, color, value);
            }

            if (isBorder)
                resGrid[i][j] = color;
        }

        /// <summary>
        /// Uncrossed Lines (My Solution)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int MaxUncrossedLines(int[] A, int[] B)
        {
            int[,] m = new int[A.Length, B.Length];
            for (int i = 0; i < A.Length; i++)
            for (int j = 0; j < B.Length; j++)
            {
                if (A[i] == B[j])
                    m[i, j] = i - 1 >= 0 && j - 1 >= 0 ? m[i - 1, j - 1] + 1 : 1;
                else m[i, j] = Math.Max(i - 1 >= 0 ? m[i - 1, j] : 0, j - 1 >= 0 ? m[i, j - 1] : 0);
            }

            return m[A.Length - 1, B.Length - 1];
        }
    }
}
