using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Distribute Coins in Binary Tree (Not Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int DistributeCoins(TreeNode root)
        {
            int res = 0;
            Dfs(root);

            return res;

            int Dfs(TreeNode node)
            {
                if (node == null)
                    return 0;
                int left = Dfs(node.left), right = Dfs(node.right);
                res += Math.Abs(left) + Math.Abs(right);
                return node.val + left + right - 1;
            }
        }
    }
}
