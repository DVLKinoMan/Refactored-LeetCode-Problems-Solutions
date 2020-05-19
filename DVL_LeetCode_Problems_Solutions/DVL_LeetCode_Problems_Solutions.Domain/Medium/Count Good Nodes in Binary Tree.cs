using System;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Count Good Nodes in Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int GoodNodes(TreeNode root, int maxValue = -10001)
        {
            if (root == null)
                return 0;

            int max = Math.Max(maxValue, root.val);

            return GoodNodes(root.left, max) + GoodNodes(root.right, max) + (root.val >= maxValue ? 1 : 0);
        }
    }
}