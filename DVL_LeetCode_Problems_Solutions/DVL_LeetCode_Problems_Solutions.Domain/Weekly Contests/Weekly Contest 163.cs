using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;
using System.Collections.Generic;

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
            var visitedIndexes = new HashSet<int>();
            int max = 0;
            Dfs(0, 0);
            return max;

            void Dfs(int currSum, int stIndex)
            {
                for (int i = stIndex; i < nums.Length; i++)
                {
                    if (!visitedIndexes.Contains(i))
                    {
                        currSum += nums[i];
                        visitedIndexes.Add(i);
                        if (currSum % 3 == 0)
                           max = Math.Max(max, currSum);
                        Dfs(currSum, i + 1);
                        currSum -= nums[i];
                        visitedIndexes.Remove(i);
                    }
                }
            }
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
