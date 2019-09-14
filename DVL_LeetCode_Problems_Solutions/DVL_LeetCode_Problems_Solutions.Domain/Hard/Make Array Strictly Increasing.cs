using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Hard
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Make Array Strictly Increasing (Not Mine)
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int MakeArrayIncreasing(int[] arr1, int[] arr2)
        {
            Array.Sort(arr2);
            int[,] dp=new int[2001,2001];
            int res = MakeArrayIncreasingHelper(arr1, arr2, 0, 0, int.MinValue, dp);
            return res > arr2.Length ? -1 : res - 1;
        }

        private static int MakeArrayIncreasingHelper(int[] a1, int[] a2, int i1, int i2, int prev, int[,] dp)
        {
            if (i1 >= a1.Length)
                return 1;
            bool wasinIf = false;
            for (int i = i2; i < a2.Length; i++)
                if (a2[i] > prev)
                {
                    i2 = i;
                    wasinIf = true;
                    break;
                }

            if (!wasinIf)
                i2 = a2.Length;

            if (dp[i1, i2] != 0)
                return dp[i1, i2];
            var r1 = i2 < a2.Length ? 1 + MakeArrayIncreasingHelper(a1, a2, i1 + 1, i2, a2[i2], dp) : a2.Length + 1;
            var r2 = prev < a1[i1] ? MakeArrayIncreasingHelper(a1, a2, i1 + 1, i2, a1[i1], dp) : a2.Length + 1;
            return dp[i1, i2] = Math.Min(r1, r2);
        }
    }
}
