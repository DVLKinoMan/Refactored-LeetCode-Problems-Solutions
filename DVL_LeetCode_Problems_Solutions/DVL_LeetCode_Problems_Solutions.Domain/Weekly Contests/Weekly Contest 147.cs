using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// N-th Tribonacci Number (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Tribonacci(int n)
        {
            if (n <= 1)
                return n;
            if (n == 2)
                return 1;

            var queue = new Queue<int>();
            queue.Enqueue(0);
            queue.Enqueue(1);
            queue.Enqueue(1);
            int sum = 2;

            int count = 2;
            while (count < n)
            {
                queue.Enqueue(sum);
                sum += sum;
                sum -= queue.Dequeue();
                count++;
            }

            queue.Dequeue();
            queue.Dequeue();
            return queue.Dequeue();
        }

        /// <summary>
        /// Alphabet Board Path (Mine)
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string AlphabetBoardPath(string target)
        {
            var res = new StringBuilder();
            int raw = 0, col = 0;
            foreach (var ch in target)
            {
                int rawNum = (ch - 'a') / 5, colNum = (ch - 'a') % 5;
                if (rawNum != 5)
                {
                    while (rawNum < raw)
                    {
                        raw--;
                        res.Append('U');
                    }

                    while (rawNum > raw)
                    {
                        raw++;
                        res.Append('D');
                    }

                    while (colNum < col)
                    {
                        col--;
                        res.Append('L');
                    }

                    while (colNum > col)
                    {
                        col++;
                        res.Append('R');
                    }
                }
                else
                {
                    while (colNum < col)
                    {
                        col--;
                        res.Append('L');
                    }

                    while (colNum > col)
                    {
                        col++;
                        res.Append('R');
                    }

                    while (rawNum < raw)
                    {
                        raw--;
                        res.Append('U');
                    }

                    while (rawNum > raw)
                    {
                        raw++;
                        res.Append('D');
                    }
                }

                res.Append('!');
            }

            return res.ToString();
        }

        /// <summary>
        /// Largest 1-Bordered Square (Not Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int Largest1BorderedSquare(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            int[,] left = new int[m, n], top = new int[m, n];
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (grid[i][j] > 0)
                {
                    left[i, j] = j > 0 ? left[i, j - 1] + 1 : 1;
                    top[i, j] = i > 0 ? top[i - 1, j] + 1 : 1;
                }

            for (int len = Math.Min(m, n); len > 0; len--)
            for (int i = 0; i <= m - len; i++)
            for (int j = 0; j <= n - len; j++)
                if (left[i, j + len - 1] >= len && top[i + len - 1, j] >= len &&
                    left[i + len - 1, j + len - 1] >= len && top[i + len - 1, j + len - 1] >= len)
                    return len * len;
            return 0;
        }
    }

}
