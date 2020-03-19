using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Smallest Range I (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static int SmallestRangeI(int[] A, int K)
        {
            if (A.Length == 1)
                return 0;

            int max = A.Max(), min = A.Min();
            int mid = (max + min) / 2;
            int start = min + K > mid ? mid : min + K;
            int end = max - K < mid ? mid : max - K;
            return end - start;
        }
    }
}