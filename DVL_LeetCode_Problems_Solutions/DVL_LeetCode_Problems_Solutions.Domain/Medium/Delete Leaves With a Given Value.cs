using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Delete Leaves With a Given Value (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            Dfs(root, null, false);

            return root;

            void Dfs(TreeNode node, TreeNode parent, bool isLeft)
            {
                if (node == null)
                    return;

                if (node.left == null && node.right == null && node.val == target)
                {
                    if (parent == null)
                        root = null;
                    else if (isLeft)
                        parent.left = null;
                    else parent.right = null;
                }
                else
                {
                    Dfs(node.left, node, true);
                    Dfs(node.right, node, false);
                    DeleteIfNecessary(node, parent, isLeft);
                }
            }

            void DeleteIfNecessary(TreeNode node, TreeNode parent, bool isLeft)
            {
                if (node.left == null && node.right == null && node.val == target)
                {
                    if (parent == null)
                        root = null;
                    else if (isLeft)
                        parent.left = null;
                    else parent.right = null;
                }
            }
        }
    }
}
