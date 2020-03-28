using System;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Depth of Binary Tree (Not Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = MinDepth(root.left);
            int right = MinDepth(root.right);
            return (left == 0 || right == 0) ? left + right + 1 : Math.Min(left, right) + 1;
        }
    }
}