using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid Boomerang (My Solution)
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static bool IsBoomerang(int[][] points)
        {
            int x1 = points[0][0],
                y1 = points[0][1],
                x2 = points[1][0],
                y2 = points[1][1],
                x3 = points[2][0],
                y3 = points[2][1];
            return (y1 - y2) * (x1 - x3) != (y1 - y3) * (x1 - x2);
        }

        /// <summary>
        /// Binary Search Tree to Greater Sum Tree (My Solution)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static TreeNode BstToGst(TreeNode root)
        {
            int sum = 0;
            BstToGstHelper(root, ref sum);
            return root;
        }

        private static void BstToGstHelper(TreeNode node, ref int sum)
        {
            if (node.right != null)
                BstToGstHelper(node.right, ref sum);
            sum += node.val;
            node.val = sum;

            if (node.left != null)
                BstToGstHelper(node.left, ref sum);
        }

        /// <summary>
        /// Minimum Score Triangulation of Polygon (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MinScoreTriangulation(int[] A)
        {
            int n = A.Length;
            int[,] dp = new int[n,n];
            for (int d = 2; d < n; ++d)
            {
                for (int i = 0; i + d < n; ++i)
                {
                    int j = i + d;
                    dp[i,j] = int.MaxValue;
                    for (int k = i + 1; k < j; ++k)
                        dp[i,j] = Math.Min(dp[i,j], dp[i,k] + dp[k,j] + A[i] * A[j] * A[k]);
                }
            }

            return dp[0,n - 1];
        }
    }
}
