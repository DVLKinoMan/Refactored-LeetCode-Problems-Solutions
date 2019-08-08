using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Validate Binary Search Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static bool IsValidBST(TreeNode root, int? max = null, int? min = null)
        {
            if (root == null)
                return true;

            if ((max != null && root.val >= max) || (min != null && root.val <= min))
                return false;

            return IsValidBST(root.left, root.val, min) && IsValidBST(root.right, max, root.val);
        }

        /// <summary>
        /// Validate Binary Search Tree (Better Solution (very little) - not mine, but my implementation)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static bool IsValidBST2(TreeNode root)
        {
            var list = new List<int>();
            IsValidBST2Helper(root, list);
            for (int i = 1; i < list.Count; i++)
                if (list[i] < list[i + 1])
                    return false;

            return true;
        }

        private static void IsValidBST2Helper(TreeNode node, List<int> list)
        {
            if (node == null)
                return;

            IsValidBST2Helper(node.left, list);
            list.Add(node.val);
            IsValidBST2Helper(node.right, list);
        } 
    }
}
