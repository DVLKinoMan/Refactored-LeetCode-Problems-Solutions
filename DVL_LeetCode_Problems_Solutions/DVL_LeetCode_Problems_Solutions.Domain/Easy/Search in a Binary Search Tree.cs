using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Search in a Binary Search Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val)
                return root;

            return SearchBST(root.left, val) ?? SearchBST(root.right, val);
        }
    }
}
