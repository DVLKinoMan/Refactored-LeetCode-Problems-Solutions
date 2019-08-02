using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Depth of Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public static int MaxDepth(TreeNode root, int h = 0)
        {
            if (root == null)
                return h;

            return Math.Max(MaxDepth(root.left, h + 1), MaxDepth(root.right, h + 1));
        }
    }
}
