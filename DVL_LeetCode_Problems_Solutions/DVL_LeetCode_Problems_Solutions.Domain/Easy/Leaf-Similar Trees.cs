using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Leaf-Similar Trees (Mine)
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        /// <returns></returns>
        public static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var root1Enumerator = LeafValues(root1).GetEnumerator();
            var root2Enumerator = LeafValues(root2).GetEnumerator();

            while (root1Enumerator.MoveNext() && root2Enumerator.MoveNext())
                if (root1Enumerator.Current != root2Enumerator.Current)
                    return false;

            return !root1Enumerator.MoveNext() && !root2Enumerator.MoveNext();

            IEnumerable<int> LeafValues(TreeNode treeNode)
            {
                if (treeNode.left == null && treeNode.right == null)
                {
                    yield return treeNode.val;
                    yield break;
                }

                if (treeNode.left != null)
                    foreach (var leftVal in LeafValues(treeNode.left))
                        yield return leftVal;

                if (treeNode.right != null)
                    foreach (var rightVal in LeafValues(treeNode.right))
                        yield return rightVal;
            }
        }
    }
}
