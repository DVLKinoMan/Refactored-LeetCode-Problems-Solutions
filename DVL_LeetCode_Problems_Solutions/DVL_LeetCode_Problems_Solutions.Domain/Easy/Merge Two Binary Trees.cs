using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Merge Two Binary Trees (Mine)
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return null;

            return new TreeNode((t1 != null ? t1.val : 0) + (t2 != null ? t2.val : 0))
            {
                left = MergeTrees(t1?.left, t2?.left),
                right = MergeTrees(t1?.right, t2?.right)
            };
        }
    }
}
