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

        public static int ShortestPath(int[][] grid, int k)
        {
            int m = grid.Length, n = grid[0].Length;
            var dict = new Dictionary<(int, int), int>();
            int val = Dfs(0, 0, new HashSet<(int, int)>() {(0, 0)}, k);
            return val == int.MaxValue ? -1 : val;

            int Dfs(int i, int j, HashSet<(int, int)> set, int currK, int currCount = 0)
            {
                if (dict.ContainsKey((i, j)))
                    return dict[(i, j)];
                if (i == m - 1 && j == n - 1)
                    return currCount;

                int min = int.MaxValue;
                //Down
                if (i + 1 < m && !set.Contains((i + 1, j)) && (grid[i+1][j] == 0 || currK > 0))
                {
                    set.Add((i + 1, j));
                    min = Math.Min(min, Dfs(i + 1, j, set, grid[i + 1][j] == 1 ? currK - 1 : currK, currCount + 1));
                    set.Remove((i + 1, j));
                }

                //Up
                if (i - 1 >= 0 && !set.Contains((i - 1, j)) && (grid[i - 1][j] == 0 || currK > 0))
                {
                    set.Add((i - 1, j));
                    min = Math.Min(min, Dfs(i - 1, j, set, grid[i - 1][j] == 1 ? currK - 1 : currK, currCount + 1));
                    set.Remove((i - 1, j));
                }

                //Left
                if (j - 1 >= 0 && !set.Contains((i, j - 1)) && (grid[i][j - 1] == 0 || currK > 0))
                {
                    set.Add((i, j - 1));
                    min = Math.Min(min, Dfs(i, j - 1, set, grid[i][j - 1] == 1 ? currK - 1 : currK, currCount + 1));
                    set.Remove((i, j- 1));
                }


                //Right
                if (j + 1 < n && !set.Contains((i, j + 1)) && (grid[i][j + 1] == 0 || currK > 0))
                {
                    set.Add((i, j + 1));
                    min = Math.Min(min, Dfs(i, j + 1, set, grid[i][j + 1] == 1 ? currK - 1 : currK, currCount + 1));
                    set.Remove((i, j + 1));
                }

                dict.Add((i, j), min);
                return min;
            }
        }
    }
}
