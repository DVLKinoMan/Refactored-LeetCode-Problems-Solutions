using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Tree Coloring Game (My Implementation)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool BtreeGameWinningMove(TreeNode root, int n, int x)
        {
            if (root == null)
                return false;

            if (root.val == x)
            {
                int leftCount = BtreeGameWinningMoveHelper(root.left);
                int rightCount = BtreeGameWinningMoveHelper(root.right);
                int parentCount = n - leftCount - rightCount - 1;
                int max = Math.Max(leftCount, Math.Max(rightCount, parentCount));
                return max > n - max;
            }

            return BtreeGameWinningMove(root.left, n, x) || BtreeGameWinningMove(root.right, n, x);
        }

        private static int BtreeGameWinningMoveHelper(TreeNode node)
        {
            if (node == null)
                return 0;

            return BtreeGameWinningMoveHelper(node.left) + BtreeGameWinningMoveHelper(node.right) + 1;
        }
    }
}
