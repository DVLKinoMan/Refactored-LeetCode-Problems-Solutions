using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Diameter of Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            int max = 0;
            MaxHeight(root);

            return max;

            int MaxHeight(TreeNode node)
            {
                if (node == null)
                    return 0;

                int left = MaxHeight(node.left) + 1;
                int right = MaxHeight(node.right) + 1;
                max = Math.Max(max, left + right - 2);

                return Math.Max(left, right);
            }
        }
    }
}
