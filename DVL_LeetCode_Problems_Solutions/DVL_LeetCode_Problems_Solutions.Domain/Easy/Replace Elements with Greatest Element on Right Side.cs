using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Replace Elements with Greatest Element on Right Side (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] ReplaceElements(int[] arr)
        {
            int max = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int curr = arr[i];
                arr[i] = max;
                max = Math.Max(max, curr);
            }

            return arr;
        }
    }
}
