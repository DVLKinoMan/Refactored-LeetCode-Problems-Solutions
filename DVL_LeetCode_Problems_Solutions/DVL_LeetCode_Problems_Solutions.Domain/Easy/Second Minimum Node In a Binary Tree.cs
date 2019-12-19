using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Second Minimum Node In a Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int FindSecondMinimumValue(TreeNode root)
        {
            if (root == null)
                return -1;

            int min = root.val, res = -1;
            Dfs(root);

            return res;

            void Dfs(TreeNode curr)
            {
                if (curr == null)
                    return;

                if (curr.val > min)
                    res = Math.Min(res == -1 ? int.MaxValue : res, curr.val);

                Dfs(curr.left);
                Dfs(curr.right);
            }
        }
    }
}
