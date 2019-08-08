using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Construct String from Binary Tree (Mine)
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string Tree2str(TreeNode t)
        {
            if (t == null)
                return string.Empty;

            string left = Tree2str(t.left);
            string right = Tree2str(t.right);

            string result = "";

            if (!string.IsNullOrEmpty(left) || !string.IsNullOrEmpty(right))
                result+=$"({left})";

            if (!string.IsNullOrEmpty(right))
                result += $"({right})";

            return $"{t.val}{result}";
        }
    }
}
