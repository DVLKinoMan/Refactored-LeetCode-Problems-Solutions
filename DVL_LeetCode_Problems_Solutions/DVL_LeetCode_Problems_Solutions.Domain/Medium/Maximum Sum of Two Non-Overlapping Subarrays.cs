using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Sum of Two Non-Overlapping Subarrays (My Solution)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="L"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public static int MaxSumTwoNoOverlap(int[] A, int L, int M)
        {
            int[] lArr = new int[A.Length - L + 1];
            lArr[0] = A.Take(L).Sum();
            for (int i = 1; i < lArr.Length; i++)
                lArr[i] = lArr[i - 1] - A[i - 1] + A[i + L - 1];

            int[] mArr = new int[A.Length - M + 1];
            mArr[0] = A.Take(M).Sum();
            for (int i = 1; i < mArr.Length; i++)
                mArr[i] = mArr[i - 1] - A[i - 1] + A[i + M - 1];

            int max = 0;
            for (int i = 0; i < lArr.Length; i++)
            for (int j = 0; j < mArr.Length; j++)
                if ((j < i && j + M <= i) || j >= i + L)
                {
                    int currSum = lArr[i] + mArr[j];
                    if (currSum > max)
                        max = currSum;
                }

            return max;
        }
    }
}
