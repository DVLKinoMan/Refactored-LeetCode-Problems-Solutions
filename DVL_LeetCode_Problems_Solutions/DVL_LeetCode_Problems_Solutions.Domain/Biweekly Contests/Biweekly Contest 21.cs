using System;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int LongestZigZag(TreeNode root)
        {
            int max = 0;
            Dfs(root, 0, false, true);
            Dfs(root, 0, true, true);
            return max;

            int Dfs(TreeNode node, int depth = 0, bool goLeft = true, bool isRoot = false)
            {
                if (node == null)
                    return depth - 1;

                if (goLeft)
                {
                    max = Math.Max(max, Dfs(node.left, depth + 1, false));
                    if (!isRoot)
                        max = Math.Max(max, LongestZigZag(node.right));
                }
                else
                {
                    max = Math.Max(max, Dfs(node.right, depth + 1));
                    if (!isRoot)
                        max = Math.Max(max, LongestZigZag(node.left));
                }

                return max;
            }
        }
    }
}