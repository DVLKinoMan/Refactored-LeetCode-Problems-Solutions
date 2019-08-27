using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sum Root to Leaf Numbers (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int SumNumbers(TreeNode root, string s = "")
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return int.Parse(s + root.val);

            int sum = 0;
            if (root.left != null)
                sum += SumNumbers(root.left, s + root.val);
            if (root.right != null)
                sum += SumNumbers(root.right, s + root.val);

            return sum;
        }
    }
}
