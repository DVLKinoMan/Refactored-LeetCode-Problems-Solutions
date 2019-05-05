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
        /// Minimum Score Triangulation of Polygon (Not Works)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MinScoreTriangulation(int[] A)
        {
            Array.Sort(A);
            int sum = 0, count = 0, n = A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        if (count == n - 2)
                            return sum;
                        sum += (A[i] * A[j] * A[k]);
                        count++;
                    }
                }
            }

            return sum;
        }
    }
}
