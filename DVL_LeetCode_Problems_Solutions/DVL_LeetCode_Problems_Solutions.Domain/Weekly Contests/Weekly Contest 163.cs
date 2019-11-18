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

        /// <summary>
        /// Greatest Sum Divisible by Three (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSumDivThree(int[] nums)
        {
            var dp = new int[]{0, int.MinValue, int.MinValue};

            foreach (var num in nums)
            {
                var dp2 = new int[3];
                for (int i = 0; i < 3; i++)
                    dp2[(i + num) % 3] = Math.Max(dp[(i + num) % 3], dp[i] + num);
                dp = dp2;
            }

            return dp[0];
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
