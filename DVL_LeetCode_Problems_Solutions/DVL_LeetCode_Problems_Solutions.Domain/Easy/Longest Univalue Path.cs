using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Univalue Path (Not Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int LongestUnivaluePath(TreeNode root)
        {
            if (root == null)
                return 0;
            int len = 0;
            LongestUnivaluePathHelper(root, root.val, ref len);
            return len;
        }

        private static int LongestUnivaluePathHelper(TreeNode node, int val, ref int len)
        {
            if (node == null)
                return 0;
            int left = LongestUnivaluePathHelper(node.left, node.val, ref len);
            int right = LongestUnivaluePathHelper(node.right, node.val, ref len);
            len = Math.Max(len, left + right);
            if (val == node.val)
                return Math.Max(left, right) + 1;
            return 0;
        }
    }
}
