namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Count Different Palindromic Subsequences (Not Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int CountPalindromicSubsequences(string S)
        {
            int[,] dp=new int[S.Length,S.Length];
            for (int i = 0; i < S.Length; i++)
                dp[i, i] = 1;
            for (int distance = 1; distance < S.Length; distance++)
            {
                for (int i = 0; i < S.Length - distance; i++)
                {
                    int j = i + distance;
                    if (S[i] == S[j])
                    {
                        int low = i + 1;
                        int high = j - 1;
                        while (low <= high && S[low] != S[j])
                            low++;
                        while (low <= high && S[high] != S[j])
                            high--;
                        if (low > high)
                            dp[i, j] = dp[i + 1, j - 1] * 2 + 2;
                        else if (low == high)
                            dp[i, j] = dp[i + 1, j - 1] * 2 + 1;
                        else
                            dp[i, j] = dp[i + 1, j - 1] * 2 - dp[low + 1, high - 1];
                    }
                    else dp[i, j] = dp[i + 1, j] + dp[i, j - 1] - dp[i + 1, j - 1];

                    dp[i, j] = dp[i, j] < 0 ? dp[i, j] + 1000000007 : dp[i, j] % 1000000007;
                }
            }

            return dp[0, S.Length - 1];
        }
    }
}
