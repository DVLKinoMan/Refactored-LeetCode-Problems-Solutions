using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Balanced Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;

            bool res = true;
            IsBalancedHelper(root, ref res);

            return res;
        }

        private static int IsBalancedHelper(TreeNode node, ref bool res)
        {
            if (node == null)
                return 0;

            int leftHeight = IsBalancedHelper(node.left, ref res) + 1;
            int rightHeight = IsBalancedHelper(node.right, ref res) + 1;

            if (Math.Abs(leftHeight - rightHeight) > 1)
                res = false;

            return Math.Max(leftHeight, rightHeight);
        }
    }
}
