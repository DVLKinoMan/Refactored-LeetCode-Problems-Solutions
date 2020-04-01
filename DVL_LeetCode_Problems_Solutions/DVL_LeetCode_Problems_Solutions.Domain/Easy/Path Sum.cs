using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Path Sum (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <param name="currSum"></param>
        /// <returns></returns>
        public static bool HasPathSum(TreeNode root, int sum, int currSum = 0)
        {
            if (root == null)
                return false;
            if (root.left == null && root.right == null)
                return sum == currSum;

            return HasPathSum(root.left, sum, currSum + root.val) ||
                   HasPathSum(root.right, sum, currSum + root.val);
        }
    }
}