using System.Collections.Generic;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Two Sum IV - Input is a BST (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool FindTarget(TreeNode root, int k) {
            var set = new HashSet<int>();
            return Dfs(root);
            
            bool Dfs(TreeNode node)
            {
                if (node == null)
                    return false;

                if (set.Contains(node.val))
                    return true;

                set.Add(k - node.val);
                return Dfs(node.left) || Dfs(node.right);
            }
        }
    }
}