using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Range Sum of BST (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="L"></param>
        /// <param name="R"></param>
        /// <returns></returns>
        public static int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return 0;

            int sum = 0;
            if (root.val > L && root.val < R)
                sum += root.val;
            sum += RangeSumBST(root.left, L, R);
            sum += RangeSumBST(root.right, L, R);

            return sum;
        }
    }
}
