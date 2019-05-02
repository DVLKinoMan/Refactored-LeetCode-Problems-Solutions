using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Difference Between Node and Ancestor (Not mine Solution)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxAncestorDiff(TreeNode root)
        {
            return MaxAncestorDiffHelper(root, root.val, root.val);
        }

        public static int MaxAncestorDiffHelper(TreeNode node, int max, int min)
        {
            if (node == null)
                return max - min;

            max = Math.Max(max, node.val);
            min = Math.Min(min, node.val);

            return Math.Max(MaxAncestorDiffHelper(node.left, max, min), MaxAncestorDiffHelper(node.right, max, min));
        }
    }
}
