using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Hard
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Tree Postorder Traversal (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root != null)
                list = PostorderTraversalHelper(root).ToList();

            return list;
        }

        private static IEnumerable<int> PostorderTraversalHelper(TreeNode node)
        {
            if (node.left != null)
                foreach (var nod in PostorderTraversalHelper(node.left))
                    yield return nod;
            if (node.right != null)
                foreach (var nod in PostorderTraversalHelper(node.right))
                    yield return nod;
            yield return node.val;
        }
    }
}
