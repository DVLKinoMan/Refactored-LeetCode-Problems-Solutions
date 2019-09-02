using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Tree Inorder Traversal (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root != null)
                list = InorderTraversalHelper(root).ToList();

            return list;
        }

        private static IEnumerable<int> InorderTraversalHelper(TreeNode node)
        {
            if (node.left != null)
                foreach (var nod in InorderTraversalHelper(node.left))
                    yield return nod;
            yield return node.val;
            if (node.right != null)
                foreach (var nod in InorderTraversalHelper(node.right))
                    yield return nod;
        }
    }
}
