using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Solve N Queens II (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int TotalNQueens(int n)
        {
            int count = 0;
            var queensCorrdinates = new List<Tuple<int, int>>();

            int i = 0, j = 0;
            while (true)
            {
                if (i == 0 && j == n)
                    break;
                if (j == n)
                {
                    i = queensCorrdinates.Last().Item1;
                    j = queensCorrdinates.Last().Item2 + 1;
                    queensCorrdinates.RemoveAt(queensCorrdinates.Count - 1);
                    continue;
                }
                if (CanPlaceQueenIn(i, j, queensCorrdinates))
                {
                    queensCorrdinates.Add(Tuple.Create(i, j));
                    if (queensCorrdinates.Count == n)
                    {
                        count++;
                        queensCorrdinates.RemoveAt(queensCorrdinates.Count - 1);
                    }
                    else
                    {
                        j = 0;
                        i++;
                        continue;
                    }
                }
                j++;
            }

            return count;
        }

        /// <summary>
        /// Total N Queens II (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int totalNQueens(int n)
        {
            int count = 0;
            bool[] cols = new bool[n]; // columns   |
            bool[] d1 = new bool[2 * n]; // diagonals \
            bool[] d2 = new bool[2 * n]; // diagonals /
            backtracking(0, cols, d1, d2, n, ref count);
            return count;
        }

        private static void backtracking(int row, bool[] cols, bool[] d1, bool[] d2, int n, ref int count)
        {
            if (row == n) count++;

            for (int col = 0; col < n; col++)
            {
                int id1 = col - row + n;
                int id2 = col + row;
                if (cols[col] || d1[id1] || d2[id2]) continue;

                cols[col] = true; d1[id1] = true; d2[id2] = true;
                backtracking(row + 1, cols, d1, d2, n,ref count);
                cols[col] = false; d1[id1] = false; d2[id2] = false;
            }
        }
    }
}
