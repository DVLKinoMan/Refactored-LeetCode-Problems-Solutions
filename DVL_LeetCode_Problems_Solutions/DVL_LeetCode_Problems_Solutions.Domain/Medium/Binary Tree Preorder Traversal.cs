using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        ///  Binary Tree Preorder Traversal (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root != null)
                list = PreorderTraversalHelper(root).ToList();

            return list;
        }

        private static IEnumerable<int> PreorderTraversalHelper(TreeNode node)
        {
            yield return node.val;
            if (node.left != null)
                foreach (var nod in PreorderTraversalHelper(node.left))
                    yield return nod;
            if (node.right != null)
                foreach (var nod in PreorderTraversalHelper(node.right))
                    yield return nod;
        }
    }
}
