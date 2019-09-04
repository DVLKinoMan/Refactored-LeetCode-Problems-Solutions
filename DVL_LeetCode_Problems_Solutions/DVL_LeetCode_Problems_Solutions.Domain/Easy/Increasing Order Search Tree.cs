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
        //todo???
        public static TreeNode IncreasingBST(TreeNode root, TreeNode parent = null)
        {
            TreeNode node;
            if (root.left != null)
                node = IncreasingBST(root.left, root);
            else
                node = root;

            if (root.right == null)
                root.right = parent ?? root.right;
            else root.right = IncreasingBST(root.right);

            root.left = null;

            return node;
        }
    }
}
