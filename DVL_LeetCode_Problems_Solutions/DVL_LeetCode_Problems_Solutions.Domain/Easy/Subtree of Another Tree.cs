using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Subtree of Another Tree (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="mustHaveEqualValues"></param>
        /// <returns></returns>
        public static bool IsSubtree(TreeNode s, TreeNode t, bool mustHaveEqualValues = false)
        {
            if (s == null && t == null)
                return true;
            if (s == null || t == null)
                return false;
            if (s.val == t.val && IsSubtree(s.left, t.left, true) && IsSubtree(s.right, t.right, true))
                    return true;

            return !mustHaveEqualValues && (IsSubtree(s.left, t) || IsSubtree(s.right, t));
        }
    }
}
