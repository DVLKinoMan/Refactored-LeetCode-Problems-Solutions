using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
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
                dp[i, 0] = (dp[i - 1, 1] + dp[i - 1, 2] + dp[i - 1, 4])%mod;
                dp[i, 1] = (dp[i - 1, 0] + dp[i - 1, 2]) % mod;
                dp[i, 2] = (dp[i - 1, 1] + dp[i - 1, 3]) % mod;
                dp[i, 3] = (dp[i - 1, 2])% mod;
                dp[i, 4] = (dp[i - 1, 2] + dp[i - 1, 3]) % mod;
            }

            return (dp[n - 1, 0] + dp[n - 1, 1] + dp[n - 1, 2] + dp[n - 1, 3] + dp[n - 1, 4]) % mod;
        }
    }
}
