using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Count Vowels Permutation (Mine with hints)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountVowelPermutation(int n)
        {
            int mod = (int)Math.Pow(10, 9) + 7;
            int[,] dp = new int[n, 5];
            for (int i = 0; i < 5; i++)
            {
                dp[0, i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                dp[i, 0] = ModFunc(ModFunc(dp[i - 1, 1], dp[i - 1, 2]), dp[i - 1, 4]);
                dp[i, 1] = ModFunc(dp[i - 1, 0], dp[i - 1, 2]);
                dp[i, 2] = ModFunc(dp[i - 1, 1], dp[i - 1, 3]);
                dp[i, 3] = dp[i - 1, 2];
                dp[i, 4] = ModFunc(dp[i - 1, 2], dp[i - 1, 3]);
            }

            return ModFunc(ModFunc(ModFunc(dp[n - 1, 0], dp[n - 1, 1]),  ModFunc(dp[n - 1, 2], dp[n - 1, 3])), dp[n - 1, 4]);

            int ModFunc(int a, int b) => (a + b) % mod;
        }
    }
}
