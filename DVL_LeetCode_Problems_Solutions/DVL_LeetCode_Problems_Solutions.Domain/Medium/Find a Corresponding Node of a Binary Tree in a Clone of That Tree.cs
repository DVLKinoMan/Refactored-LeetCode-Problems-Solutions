using System.Text;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find a Corresponding Node of a Binary Tree in a Clone of That Tree (Mine)
        /// </summary>
        /// <param name="original"></param>
        /// <param name="cloned"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            string path = null;
            StringBuilder builder = new StringBuilder();
            Dfs(original);
            return path.Length == 0 ? cloned : GetNode(cloned);

            void Dfs(TreeNode node)
            {
                if (node == null)
                    return;

                if (node == target)
                    path = builder.ToString();
                
                builder.Append("R");
                Dfs(node.right);
                builder.Remove(builder.Length - 1, 1);
                
                builder.Append("L");
                Dfs(node.left);
                builder.Remove(builder.Length - 1, 1);
            }

            TreeNode GetNode(TreeNode node, int index = 0)
            {
                if (index == path.Length - 1)
                    return path[index] == 'L' ? node.left : node.right;

                return path[index] == 'L' ? GetNode(node.left, index + 1) : GetNode(node.right, index + 1);
            }
        }
    }
}