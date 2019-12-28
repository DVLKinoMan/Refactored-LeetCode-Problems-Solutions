using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Swaps To Make Sequences Increasing (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int MinSwap(int[] A, int[] B)
        {
            int fixRecord = 0, swapRecord = 1;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i - 1] >= B[i] || B[i - 1] >= A[i])
                    swapRecord++;
                else if (A[i - 1] >= A[i] || B[i - 1] >= B[i])
                {
                    int temp = swapRecord;
                    swapRecord = fixRecord + 1;
                    fixRecord = temp;
                }
                else
                {
                    int min = Math.Min(swapRecord, fixRecord);
                    swapRecord = min + 1;
                    fixRecord = min;
                }
            }

            return Math.Min(fixRecord, swapRecord);
        }
    }
}
