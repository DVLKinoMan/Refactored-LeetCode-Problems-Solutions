using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Shift 2D Grid (Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int n = grid.Length, m = grid[0].Length;
            int[][] newGrid = new int[n][];
            for (int i = 0; i < n; i++)
            {
                newGrid[i] = new int[m];
            }

            k = k % (n * m);
            for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                int num = i * m + j + 1 + k;
                int iIndex = (num - 1) / m;
                int jIndex = num % m - 1;
                if (jIndex < 0)
                    jIndex = m + jIndex;
                newGrid[iIndex % n][jIndex] = grid[i][j];
            }

            return newGrid;
        }

        public static int MaxSumDivThree(int[] nums)
        {
            var dict = new Dictionary<int, List<int>>()
                {{0, new List<int>()}, {1, new List<int>()}, {2, new List<int>()}};
            foreach (var num in nums)
                dict[num % 3].Add(num);
            foreach (var list in dict.Values)
                list.Sort();

            int max = dict[0].Sum();
            int rem = Math.Min(dict[1].Count / 3, dict[2].Count / 3) * 3;
            if (rem != 0)
            {
                max += dict[1].Skip(dict[1].Count - rem).Sum();
                max += dict[2].Skip(dict[2].Count - rem).Sum();
                dict[1].RemoveRange(dict[1].Count - rem - 1, rem);
                dict[2].RemoveRange(dict[2].Count - rem - 1, rem);
            }

            if (dict[1].Count < 3 && dict[2].Count < 3)
            {
                while (dict[1].Count != 0 && dict[2].Count != 0)
                {
                    int f = dict[1].Count - 1, s = dict[2].Count - 1;
                    max += dict[1][f] += dict[2][s];
                    dict[1].RemoveAt(f);
                    dict[2].RemoveAt(s);
                }
            }
            else
            {
                if (dict[1].Count == 3)
                {
                    int sum = dict[1].Sum();
                    int secondSum = 0;
                    while (dict[1].Count != 0 && dict[2].Count != 0)
                    {
                        int f = dict[1].Count - 1, s = dict[2].Count - 1;
                        secondSum += dict[1][f] += dict[2][s];
                        dict[1].RemoveAt(f);
                        dict[2].RemoveAt(s);
                    }

                    max += Math.Max(sum, secondSum);
                }
                else
                {
                    int sum = dict[2].Sum();
                    int secondSum = 0;
                    while (dict[1].Count != 0 && dict[2].Count != 0)
                    {
                        int f = dict[1].Count - 1, s = dict[2].Count - 1;
                        secondSum += dict[1][f] += dict[2][s];
                        dict[1].RemoveAt(f);
                        dict[2].RemoveAt(s);
                    }

                    max += Math.Max(sum, secondSum);
                }
            }

            return max;
        }

        /// <summary>
        /// Find Elements in a Contaminated Binary Tree (Mine)
        /// </summary>
        public class FindElements
        {
            private HashSet<int> set;

            public FindElements(TreeNode root)
            {
                set=new HashSet<int>();
                root.val = 0;
                Recover(root);

                void Recover(TreeNode node)
                {
                    set.Add(node.val);

                    if (node.left != null)
                    {
                        node.left.val = node.val * 2 + 1;
                        Recover(node.left);
                    }

                    if (node.right != null)
                    {
                        node.right.val = node.val * 2 + 2;
                        Recover(node.right);
                    }
                }
            }

            public bool Find(int target)
            {
                return set.Contains(target);
            }
        }

    }
}
