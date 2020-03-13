using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Largest Perimeter Triangle (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int LargestPerimeter(int[] A)
        {
            Array.Sort(A);
            for (int i = A.Length - 1; i > 1; --i)
                if (A[i] < A[i - 1] + A[i - 2])
                    return A[i] + A[i - 1] + A[i - 2];
            return 0;
        }
    }
}