using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Tree Pruning (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode PruneTree(TreeNode root)
        {
            if (!PruneTreeHelper(root))
                root = null;

            return root;
        }

        private static bool PruneTreeHelper(TreeNode root)
        {
            if (root == null)
                return false;

            bool leftSubtreeHasOne = true, rightSubtreeHasOne = true;
            if (!PruneTreeHelper(root.left))
            {
                root.left = null;
                leftSubtreeHasOne = false;
            }

            if (!PruneTreeHelper(root.right))
            {
                root.right = null;
                rightSubtreeHasOne = false;
            }

            return leftSubtreeHasOne || rightSubtreeHasOne || root.val == 1;
        }
    }
}
