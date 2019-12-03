using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Invert Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            var leftNode = root.left;
            root.left = root.right;
            root.right = leftNode;
            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
