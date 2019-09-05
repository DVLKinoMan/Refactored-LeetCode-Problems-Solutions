using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Increasing Order Search Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public static TreeNode IncreasingBST(TreeNode root, TreeNode parent = null)
        {
            TreeNode node;
            if (root.left != null)
                node = IncreasingBST(root.left, root);
            else
                node = root;

            if (root.right == null)
                root.right = parent ?? root.right;
            else
            {
                root.right = IncreasingBST(root.right);
                var currNode = root.right;
                while (currNode.right != null)
                    currNode = currNode.right;

                if (parent != null)
                    currNode.right = parent;
            }

            root.left = null;

            return node;
        }
    }
}
