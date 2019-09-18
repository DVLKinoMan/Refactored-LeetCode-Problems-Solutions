using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// K-Concatenation Maximum Sum (Not Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int KConcatenationMaxSum(int[] arr, int k)
        {
            int n = arr.Length;
            long sufixMax = 0, prefixMax = 0, currPrefixSum = 0, currSufixSum = 0, currSum = 0, maxSum = 0, sum = 0;
            int mod = (int)Math.Pow(10, 9) + 7;
            for (int i = 0; i < n; i++)
            {
                currPrefixSum += arr[i] % mod;
                currSufixSum += arr[n - i - 1] % mod;
                sufixMax = Math.Max(sufixMax, currSufixSum);
                prefixMax = Math.Max(prefixMax, currPrefixSum);
                currSum = Math.Max(0, Math.Max((currSum + arr[i]) % mod, arr[i]));
                maxSum = Math.Max(maxSum, currSum);
                sum += arr[i];
            }

            if (sum > 0)
                return (int)(Math.Max(((sum * (k - 2)) % mod + sufixMax + prefixMax) % mod, maxSum % mod));
            else
                return (int)(Math.Max((prefixMax + sufixMax) % mod, maxSum % mod));
        }
    }
}
