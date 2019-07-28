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

        public static int Largest1BorderedSquare(int[][] grid)
        {
            //var dic1 = new Dictionary<(int, int), int>();
            //var dic2 = new Dictionary<(int, int), int>();
            //for (int i = 0; i < grid.Length; i++)
            //{
            //    for (int j = 0; j < grid[0].Length; j++)
            //    {
            //        if (grid[i][j] == 1)
            //        {
            //            if (dic1.ContainsKey((i, j)))
            //                dic1[(i, j)]++;
            //            else dic1.Add((i, j), 1);
            //        }
            //    }
            //}
            return 1;
        }
    }

}
