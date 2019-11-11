using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Cells with Odd Values in a Matrix (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="indices"></param>
        /// <returns></returns>
        public static int OddCells(int n, int m, int[][] indices)
        {
            int[,] matrix = new int[n, m];
            foreach (var arr in indices)
            {
                for (int j = 0; j < m; j++)
                    matrix[arr[0], j]++;
                for (int i = 0; i < n; i++)
                    matrix[i, arr[1]]++;
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (matrix[i, j] % 2 == 1)
                    count++;

            return count;
        }

        /// <summary>
        /// Reconstruct a 2-Row Binary Matrix (Not Working)
        /// </summary>
        /// <param name="upper"></param>
        /// <param name="lower"></param>
        /// <param name="colsum"></param>
        /// <returns></returns>
        public static IList<IList<int>> ReconstructMatrix(int upper, int lower, int[] colsum)
        {
            int[][] arr = new int[2][];
            int n = colsum.Length, count = 0;
            arr[0] = new int[n];
            arr[1] = new int[n];

            var set = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                if (colsum[i] == 2)
                {
                    arr[0][i] = 1;
                    arr[1][i] = 1;
                    lower--;
                    upper--;
                }
                else if (colsum[i] == 1)
                {
                    count++;
                    set.Add(i);
                }
            }

            if (count == lower + upper)
            {
                int c = 0;
                foreach (var index in set)
                {
                    if (c < upper)
                        arr[0][index] = 1;
                    else arr[1][index] = 1;
                    c++;
                }
                return arr;
            }

            return new List<IList<int>>();
        }

        /// <summary>
        /// Number of Closed Islands (Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int ClosedIsland(int[][] grid)
        {
            int n = grid.Length, m = grid[0].Length;
            var visitedSet = new HashSet<(int, int)>();
            int count = 0;
            bool isClosed;
            for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                isClosed = true;
                if (grid[i][j] == 0 && !visitedSet.Contains((i, j)))
                {
                    IsClosedIsland(i, j);
                    if (isClosed)
                        count++;
                }
            }

            return count;

            void IsClosedIsland(int i1, int j1)
            {
                if (visitedSet.Contains((i1, j1)))
                    return;

                visitedSet.Add((i1, j1));
                if (i1 == n - 1 || i1 == 0 || j1 == m - 1 || j1 == 0)
                    isClosed = false;

                if (i1 != 0 && grid[i1 - 1][j1] == 0)
                    IsClosedIsland(i1 - 1, j1);
                if (i1 != n - 1 && grid[i1 + 1][j1] == 0)
                    IsClosedIsland(i1 + 1, j1);
                if (j1 != m - 1 && grid[i1][j1 + 1] == 0)
                    IsClosedIsland(i1, j1 + 1);
                if (j1 != 0 && grid[i1][j1 - 1] == 0)
                    IsClosedIsland(i1, j1 - 1);
            }
        }
    }
}
