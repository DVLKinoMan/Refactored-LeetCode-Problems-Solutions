using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Cousins in Binary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool IsCousins(TreeNode root, int x, int y)
        {
            var (found, par, d) = Dfs(root, null, x);
            var yval = Dfs(root, null, y);

            if (found && yval.found &&  par != yval.parent && d == yval.depth)
                return true;

            return false;
            
            (bool found, TreeNode parent, int depth) Dfs(TreeNode currNode, TreeNode parent, int k, int depth = 0)
            {
                if (currNode == null)
                    return (false, default, default);

                if (currNode.val == k)
                    return (true, parent, depth);

                var left = Dfs(currNode.left, currNode, k, depth + 1);
                var right = Dfs(currNode.right, currNode, k, depth + 1);

                return left.found ? left : right;
            }
        }
    }
}