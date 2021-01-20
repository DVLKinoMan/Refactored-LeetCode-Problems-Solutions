using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Recover Binary Search Tree (Not Mine)
        /// </summary>
        /// <param name="root"></param>
        public static void RecoverTree(TreeNode root)
        {
            TreeNode prev = null,
                first = null,
                second = null;

            inOrder(root);

            int temp = first.val;
            first.val = second.val;
            second.val = temp;

            void inOrder(TreeNode node)
            {
                if (node == null) 
                    return;
                inOrder(node.left);

                if (prev != null && prev.val >= node.val)
                {
                    if (first == null) 
                        first = prev;
                    second = node;
                }

                prev = node;

                inOrder(node.right);
            }
        }
    }
}
