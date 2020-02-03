using System;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Product of Splitted Binary Tree (Not Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxProduct(TreeNode root)
        {
            int mod = (int) Math.Pow(10, 9) + 7;
            long totalTreeSum = 0, result = 0;
            totalTreeSum = SumUnder(root);
            SumUnder(root);
            return (int) (result % mod);

            int SumUnder(TreeNode node)
            {
                if (node == null)
                    return 0;
                long sum = SumUnder(node.left) + SumUnder(node.right) + node.val;
                result = Math.Max(result, sum * (totalTreeSum - sum));
                return (int) (sum % mod);
            }
        }
    }
}