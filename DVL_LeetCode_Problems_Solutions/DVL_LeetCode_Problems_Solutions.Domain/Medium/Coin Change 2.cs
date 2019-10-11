namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Coin Change 2 (Not Mine)
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="coins"></param>
        /// <returns></returns>
        public static int Change(int amount, int[] coins)
        {
            int[] dp = new int[amount + 1];
            dp[0] = 1;
            foreach (int coin in coins)
                for (int i = coin; i <= amount; i++)
                    dp[i] += dp[i - coin];
            return dp[amount];
        }
    }
}
