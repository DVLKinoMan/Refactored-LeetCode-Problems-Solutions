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
        public static bool FlipEquiv(TreeNode root1, TreeNode root2)
        {

        }

        private static bool FlipEquivHelper(TreeNode tree1Parent, TreeNode tree1Node1, TreeNode tree2Node1, TreeNode tree2Parent, TreeNode tree1Node2, TreeNode tree2Node2)
        {
            if (tree1Node1?.val != tree2Node1?.val)
            {
                if (tree1Node1?.val != tree2Node2?.val)
                    return false;

                tree1Parent.left = tree2Node2;
                tree2Parent.right = tree1Node1;

                return 
            }
        }
    }
}
