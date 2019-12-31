using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int DeepestLeavesSum(TreeNode root)
        {
            int maxHeight = 0, result = 0;
            Dfs(root);

            return result;

            void Dfs(TreeNode node, int height = 1)
            {
                if (node == null)
                    return;

                if (height > maxHeight)
                {
                    maxHeight = height;
                    result = node.val;
                }
                else if (height == maxHeight)
                    result += node.val;

                Dfs(node.left, height + 1);
                Dfs(node.right, height + 1);
            }
        }
    }
}
