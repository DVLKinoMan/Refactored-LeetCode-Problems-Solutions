using DVL_LeetCode_Problems_Solutions.Domain.Classes;
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
        /// Find Words That Can Be Formed by Characters (Mine)
        /// </summary>
        /// <param name="words"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        public static int CountCharacters(string[] words, string chars)
        {
            return words.Where(w => CountCharactersHelper(w, chars)).Sum(w => w.Length);
        }

        private static bool CountCharactersHelper(string word, string chars)
        {
            var dic = new Dictionary<char, int>();
            foreach (var ch in word)
            {
                int stIndex = dic.ContainsKey(ch) ? dic[ch] + 1 : 0;
                int index = chars.IndexOf(ch, stIndex);
                if (index >= 0)
                {
                    if (dic.ContainsKey(ch))
                        dic[ch] = index;
                    else dic.Add(ch, index);
                }
                else return false;
            }

            return true;
        }

        /// <summary>
        /// Maximum Level Sum of a Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxLevelSum(TreeNode root)
        {
            var list = new List<(TreeNode, int)>();
            list.Add((root, 1));
            int ind = 0;
            while (ind < list.Count)
            {
                var first = list[ind];
                if (first.Item1.left != null)
                    list.Add((first.Item1.left, first.Item2 + 1));
                if (first.Item1.right != null)
                    list.Add((first.Item1.right, first.Item2 + 1));
                ind++;
            }

            int maxSum = 0, level = 0;
            foreach (var item in list.GroupBy(tr => tr.Item2))
            {
                int sum = item.Sum(tr => tr.Item1.val);
                if (sum > maxSum)
                {
                    maxSum = sum;
                    level = item.First().Item2;
                }
            }

            return level;
        }

        /// <summary>
        /// As Far from Land as Possible
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int MaxDistance(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            int[,] distances = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    distances[i, j] = 1000;
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        for (int i2 = 0; i2 < m; i2++)
                        {
                            for (int j2 = 0; j2 < n; j2++)
                            {
                                if (grid[i2][j2] == 0)
                                {
                                    distances[i2, j2] = Math.Min(distances[i2, j2], distance(i, j, i2, j2));
                                }
                            }
                        }
                    }
                }
            }

            int max = -1;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (distances[i, j] != 1000 && max < distances[i, j])
                        max = distances[i, j];

            int distance(int x, int y, int x1, int y1)
            {
                return Math.Abs(x - x1) + Math.Abs(y - y1);
            }

            return max;
        }
    }
}
