using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Tree Tilt (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int FindTilt(TreeNode root)
        {
            int result = 0;
            Sum(root);
            return result;

            int Sum(TreeNode node)
            {
                if (node == null)
                    return 0;

                int leftSum = node.left != null ? Sum(node.left) : 0;
                int rightSum = node.right!= null ? Sum(node.right) : 0;
                result += Math.Abs(leftSum - rightSum);

                return leftSum + rightSum + node.val;
            }
        }
    }
}
