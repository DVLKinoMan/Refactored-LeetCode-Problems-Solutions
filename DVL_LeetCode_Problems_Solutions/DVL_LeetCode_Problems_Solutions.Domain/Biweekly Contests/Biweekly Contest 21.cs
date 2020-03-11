using System;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest ZigZag Path in a Binary Tree (Not Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int LongestZigZag(TreeNode root)
        {
            return Dfs(root).result;

            (int left, int right, int result) Dfs(TreeNode node)
            {
                if (node == null)
                    return (-1, -1, -1);
                (int left, int right, int result) left = Dfs(node.left), right = Dfs(node.right);
                int res = Math.Max(
                    Math.Max(left.right, right.left) + 1,
                    Math.Max(left.result, right.result)
                );
                return (left.right + 1, right.left + 1, res);
            }
        }
    }
}