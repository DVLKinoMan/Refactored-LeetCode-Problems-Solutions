using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Kth Smallest Element in a BST (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int KthSmallest(TreeNode root, int k)
        {
            int dfs = 0, res = -1;
            Dfs(root);
            return res;

            void Dfs(TreeNode node)
            {
                if (node == null)
                    return;

                Dfs(node.left);
                if(dfs == k)
                    return;

                dfs++;
                if (dfs == k)
                {
                    res = node.val;
                    return;
                }

                Dfs(node.right);
            }
        }
    }
}
