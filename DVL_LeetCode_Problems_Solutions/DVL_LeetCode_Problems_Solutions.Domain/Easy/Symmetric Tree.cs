using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Symmetric Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsSymmetric(TreeNode root)
        {
            return root == null || IsEqual(root.left, root.right);
            
            bool IsEqual(TreeNode node1, TreeNode node2)
            {
                if (node1 == null && node2 == null)
                    return true;
                if (node1 == null || node2 == null || node1.val != node2.val)
                    return false;

                return IsEqual(node1.left, node2.right) && IsEqual(node1.right, node2.left);
            }
        }
    }
}