using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Lowest Common Ancestor of a Binary Search Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == p || root == q || (root.val > p.val && root.val < q.val) || (root.val < p.val && root.val > q.val))
                return root;

            return LowestCommonAncestor(root.val < p.val ? root.right : root.left, p, q);
        }
    }
}
