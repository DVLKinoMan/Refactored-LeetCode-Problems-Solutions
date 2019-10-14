using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Dice Roll Simulation (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="rollMax"></param>
        /// <returns></returns>
        public int DieSimulator(int n, int[] rollMax)
        {
            long divisor = (long) Math.Pow(10, 9) + 7;
            long[,] dp = new long[n, 7];
            for (int j = 0; j < 6; j++)
                dp[0, j] = 1;

            dp[0, 6] = 6;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = 0; j < 6; j++)
                {
                    dp[i, j] = dp[i - 1, 6];
                    if (i - rollMax[j] < 0)
                        sum = (sum + dp[i, j]) % divisor;
                    else
                    {
                        if (i - rollMax[j] - 1 >= 0)
                            dp[i, j] = (dp[i, j] - (dp[i - rollMax[j] - 1, 6] - dp[i - rollMax[j] - 1, j])) % divisor +
                                       divisor;
                        else dp[i, j] = (dp[i, j] - 1) % divisor;
                        sum = (sum + dp[i, j]) % divisor;
                    }

                }

                dp[i, 6] = sum;
            }

            return (int) (dp[n - 1, 6]);
        }
    }
}
