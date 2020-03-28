namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Happy Prefix (Not Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string LongestPrefix(string s)
        {
            int[] dp = new int[s.Length];
            int j = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[j])
                    dp[i] = ++j;
                else if (j > 0)
                {
                    j = dp[j - 1];
                    i--;
                }
            }

            return s.Substring(0, j);
        }
    }
}