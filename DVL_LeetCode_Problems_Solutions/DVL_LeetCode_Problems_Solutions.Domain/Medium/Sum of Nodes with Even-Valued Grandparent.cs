using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sum of Nodes with Even-Valued Grandparent (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int SumEvenGrandparent(TreeNode root)
        {
            if (root == null)
                return 0;

            int sum = 0;
            if (root.val % 2 == 0)
                sum += (root.left?.left?.val ?? 0) + (root.left?.right?.val ?? 0)
                       + (root.right?.left?.val ?? 0) + (root.right?.right?.val ?? 0);

            return sum + SumEvenGrandparent(root.left) + SumEvenGrandparent(root.right);
        }
    }
}
