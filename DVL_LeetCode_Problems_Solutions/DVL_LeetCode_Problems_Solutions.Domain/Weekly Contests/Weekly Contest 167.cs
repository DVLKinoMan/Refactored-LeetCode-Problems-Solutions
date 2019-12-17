using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Convert Binary Number in a Linked List to Integer (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int GetDecimalValue(ListNode head)
        {
            var builder = new StringBuilder();
            var curr = head;
            while (curr!=null)
            {
                builder.Append(curr.val);
                curr = curr.next;
            }

            return System.Convert.ToInt32(builder.ToString(), 2);
        }

        /// <summary>
        /// Sequential Digits (Mine)
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public static IList<int> SequentialDigits(int low, int high)
        {
            var res = new List<int>();
            int len = low.ToString().Length;
            int maxLen = high.ToString().Length;
            for (; len <= maxLen; len++)
            for (int j = 1; j <= 9; j++)
            {
                var builder = new StringBuilder();
                for (int i = j; i < j + len && i <= 9; i++)
                    builder.Append(i);
                if (builder.Length == len && int.TryParse(builder.ToString(), out int num) && num >= low && num <= high)
                    res.Add(num);
            }

            return res;
        }

        /// <summary>
        /// Maximum Side Length of a Square with Sum Less than or Equal to Threshold (Not Mine)
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static int MaxSideLength(int[][] mat, int threshold)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            var sum = new int[m + 1, n + 1];

            for (int i = 1; i <= m; i++)
            for (int j = 1; j <= n; j++)
                sum[i, j] = sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1] + mat[i - 1][j - 1];

            int lo = 0, hi = Math.Min(m, n);

            while (lo <= hi)
            {
                int mid = (lo + hi) / 2;
                if (isSquareExist(mid))
                    lo = mid + 1;
                else
                    hi = mid - 1;
            }

            return hi;


            bool isSquareExist(int len)
            {
                for (int i = len; i <= m; i++)
                for (int j = len; j <= n; j++)
                    if (sum[i, j] - sum[i - len, j] - sum[i, j - len] + sum[i - len, j - len] <= threshold)
                        return true;
                return false;
            }
        }

        /// <summary>
        /// Shortest Path in a Grid with Obstacles Elimination (Not Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int ShortestPath(int[][] grid, int k)
        {
            int m = grid.Length, n = grid[0].Length;
            int[] dirs = { 0, 1, 0, -1, 0 };
            var visited = new bool[m, n, m * n];
            visited[0, 0, 0] = true;
            Queue<(int r,int c,int k,int dist)> q = new Queue<(int, int, int,int)>();
            q.Enqueue((0, 0, 0, 0));
            while (q.Count!=0)
            {
                var top = q.Dequeue();
                if (top.r == m - 1 && top.c == n - 1) 
                    return top.dist;
                for (int i = 0; i < 4; i++)
                {
                    int nr = top.r + dirs[i], nc = top.c + dirs[i + 1];
                    if (nr >= 0 && nr < m && nc >= 0 && nc < n)
                    {
                        int nk = top.k + grid[nr][nc];
                        if (nk <= k && !visited[nr, nc, nk])
                        {
                            visited[nr, nc, nk] = true;
                            q.Enqueue((nr, nc, nk, top.dist + 1));
                        }
                    }
                }
            }
            return -1;
        }
    }
}
