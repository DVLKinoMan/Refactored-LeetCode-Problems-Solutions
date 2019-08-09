using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Bottom Left Tree Value (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int FindBottomLeftValue(TreeNode root)
        {
            return FindBottomLeftValueHelper(root, 0).val;
        }

        private static (int val, int depth) FindBottomLeftValueHelper(TreeNode node, int depth)
        {
            if (node.left == null && node.right == null)
                return (node.val, depth);

            (int val, int depth) tuple = (0,0);
            if (node.left != null)
                tuple = FindBottomLeftValueHelper(node.left, depth + 1);

            if (node.right != null)
            {
                var v = FindBottomLeftValueHelper(node.right, depth + 1);
                if (v.depth > tuple.depth)
                    tuple = v;
            }

            return tuple;
        }
    }
}
