using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Depth of N-ary Tree (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxDepth(Node root)
        {
            if (root == null)
                return 0;

            return (root.children.Count == 0 ? 0 : root.children.Max(n => MaxDepth(n))) + 1;
        }
    }
}
