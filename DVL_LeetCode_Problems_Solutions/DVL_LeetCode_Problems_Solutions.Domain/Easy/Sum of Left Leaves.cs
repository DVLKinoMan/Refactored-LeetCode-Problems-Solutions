using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sum of Left Leaves (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null)
                return 0;
            
            return SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right) +
                   (root.left != null && root.left.left == null && root.left.right == null ? root.left.val : 0);
        }
    }
}