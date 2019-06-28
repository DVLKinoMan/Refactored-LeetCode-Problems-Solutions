using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Interval List Intersections (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int[][] IntervalIntersection(int[][] A, int[][] B)
        {
            int fIndex = 0, sIndex = 0;
            var result = new List<int[]>();
            while (!(fIndex == A.Length || sIndex == B.Length))
            {
                int leftBoundary = Math.Max(A[fIndex][0], B[sIndex][0]);
                int rightBoundary = Math.Min(A[fIndex][1], B[sIndex][1]);
                if (leftBoundary <= rightBoundary)
                    result.Add(new int[] { leftBoundary, rightBoundary });

                if (rightBoundary == A[fIndex][1])
                    fIndex++;
                else sIndex++;
            }

            return result.ToArray();
        }
    }
}
