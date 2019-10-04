using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            return MaxHeight(root.left) + MaxHeight(root.right);

            int MaxHeight(TreeNode node)
            {
                if (node == null)
                    return 0;

                return Math.Max(MaxHeight(node.left) + 1, MaxHeight(node.right) + 1);
            }
        }
    }
}
