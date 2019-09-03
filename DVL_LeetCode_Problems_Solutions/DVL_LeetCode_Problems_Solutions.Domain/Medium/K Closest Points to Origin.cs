using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// K Closest Points to Origin (Mine)
        /// </summary>
        /// <param name="points"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int[][] KClosest(int[][] points, int K)
        {
            double distance(int[] point) => Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
            return points.OrderBy(arr => distance(arr)).Take(K).ToArray();
        }
    }
}
