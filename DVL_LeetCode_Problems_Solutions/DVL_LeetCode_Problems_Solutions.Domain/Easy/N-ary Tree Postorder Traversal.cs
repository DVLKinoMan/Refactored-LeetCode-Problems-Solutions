using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// N-ary Tree Postorder Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> Postorder(DVL_LeetCode_Problems_Solutions.Domain.Classes.Node root)
        {
            var list = new List<int>();
            if (root == null)
                return list;

            var stack = new Stack<DVL_LeetCode_Problems_Solutions.Domain.Classes.Node>();
            stack.Push(root);

            while (stack.Count!=0)
            {
                root = stack.Pop();
                list.Add(root.val);
                foreach (var node in root.children)
                    stack.Push(node);
            }

            list.Reverse();

            return list;
        }
    }
}
