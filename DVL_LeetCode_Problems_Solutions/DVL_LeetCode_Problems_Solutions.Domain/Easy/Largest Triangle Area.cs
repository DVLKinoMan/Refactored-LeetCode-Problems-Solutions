using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Largest Triangle Area (My idea, but implementation not)
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static double LargestTriangleArea(int[][] points)
        {
            double max = 0.0;
            for (int i = 0; i < points.Length - 2; i++)
            for (int j = i + 1; j < points.Length - 1; j++)
            for (int k = j + 1; k < points.Length; k++)
                max = Math.Max(max, AreaCal(points[i], points[j], points[k]));
            return max;

            double AreaCal(int[] pt1, int[] pt2, int[] pt3)
            {
                return Math.Abs(pt1[0] * (pt2[1] - pt3[1]) + pt2[0] * (pt3[1] - pt1[1]) + pt3[0] * (pt1[1] - pt2[1])) /
                       2.0;
            }
        }
    }
}
