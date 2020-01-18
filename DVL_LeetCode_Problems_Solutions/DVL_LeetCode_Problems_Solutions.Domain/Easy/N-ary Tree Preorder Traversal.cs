using DVL_LeetCode_Problems_Solutions.Domain.Classes.Node;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// N-ary Tree Preorder Traversal (Not Mine) ps. was going in Bakuriani
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> Preorder(Node root)
        {
            var list = new List<int>();
            Preorder(root);
            return list;

            void Preorder(Node root2)
            {
                if (root2 == null)
                    return;

                list.Add(root2.val);
                foreach (var node in root2.children)
                    Preorder(node);
            }
        }
    }
}
