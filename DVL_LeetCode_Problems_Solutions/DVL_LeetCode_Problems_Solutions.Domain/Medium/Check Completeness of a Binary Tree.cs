using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Check Completeness of a Binary Tree (Not working)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsCompleteTree(TreeNode root)
        {
            (bool, int depth) depth(TreeNode node)
            {
                if (node.left == null && node.right == null)
                    return (true, 0);

                var left = node.left == null ? (false, 0) : depth(node.left);
                var right = node.right == null ? (true, 0) : depth(node.right);

                if (left.Item1 == false || right.Item1 == false || Math.Abs(left.Item2 - right.Item2) > 1)
                    return (false, 0);

                return left.Item2 < right.Item2 ? (left.Item1, left.Item2 + 1) : (right.Item1, right.Item2 + 1);
            }

            var tuple = depth(root);
            if (tuple.Item1 == false)
                return false;

            int i = 0;
            var currNode = root;
            while (currNode != null)
            {
                currNode = currNode.right;
                i++;
            }

            return tuple.depth == i;
        }
    }
}
