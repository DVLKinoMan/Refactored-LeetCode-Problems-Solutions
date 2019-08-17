using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Turbulent Subarray (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MaxTurbulenceSize(int[] A)
        {
            int maxLength = 0, currLength = 0;
            bool? prevWasGreater = null;
            for (int i = 1; i < A.Length; i++)
            {
                bool? currIsGreater = A[i] == A[i - 1] ? (bool?)null : A[i] > A[i - 1];

                if (currIsGreater != prevWasGreater && currIsGreater != null)
                    currLength++;
                else
                {
                    maxLength = Math.Max(maxLength, currLength);
                    currLength = currIsGreater == null ? 0 : 1;
                }
                prevWasGreater = currIsGreater;
            }

            maxLength = Math.Max(maxLength, currLength);

            return maxLength + 1;
        }
    }
}
