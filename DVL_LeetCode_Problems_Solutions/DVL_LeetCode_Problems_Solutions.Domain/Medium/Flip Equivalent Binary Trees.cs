using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Flip Equivalent Binary Trees (Mine)
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        /// <returns></returns>
        public static bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            return FlipEquivHelper(root1, root2, null, null);
        }

        private static bool FlipEquivHelper(TreeNode tree1LeftNode, TreeNode tree2LeftNode, TreeNode tree1RightNode,
            TreeNode tree2RightNode)
        {
            bool tree1NodesAreNull = (tree1LeftNode, tree1RightNode) == (null, null);
            bool tree2NodesAreNull = (tree2LeftNode, tree2RightNode) == (null, null);
            //bool tree1NodesAreNull = tree1LeftNode == null && tree1RightNode == null;
            //bool tree2NodesAreNull = tree2LeftNode == null && tree2RightNode == null;
            if (tree1NodesAreNull && tree2NodesAreNull)
                return true;
            if (tree2NodesAreNull || tree2NodesAreNull)
                return false;

            if ((tree1LeftNode?.val, tree1RightNode?.val) == (tree2LeftNode?.val, tree2RightNode?.val))
                return FlipEquivHelper(tree1LeftNode?.left, tree2LeftNode?.left,
                           tree1LeftNode?.right, tree2LeftNode?.right) &&
                       FlipEquivHelper(tree1RightNode?.left, tree2RightNode?.left,
                           tree1RightNode?.right, tree2RightNode?.right);

            //if (tree1LeftNode?.val == tree2LeftNode?.val && tree1RightNode?.val == tree2RightNode?.val)
            //    return FlipEquivHelper(tree1LeftNode?.left, tree2LeftNode?.left,
            //               tree1LeftNode?.right, tree2LeftNode?.right) &&
            //           FlipEquivHelper(tree1RightNode?.left, tree2RightNode?.left,
            //               tree1RightNode?.right, tree2RightNode?.right);

            if (tree1LeftNode?.val != tree2RightNode?.val || tree1RightNode?.val != tree2LeftNode?.val)
                return false;

            return FlipEquivHelper(tree1LeftNode?.left, tree2RightNode?.left,
                       tree1LeftNode?.right, tree2RightNode?.right) &&
                   FlipEquivHelper(tree1RightNode?.left, tree2LeftNode?.left,
                       tree1RightNode?.right, tree2LeftNode?.right);
        }
    }
}
