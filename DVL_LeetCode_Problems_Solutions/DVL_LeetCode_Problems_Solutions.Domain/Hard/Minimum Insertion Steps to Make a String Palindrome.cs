using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Insertion Steps to Make a String Palindrome (Mine and Not Mine versions)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MinInsertions(string s)
        {
            //My version: (slower)
            //var dict = new Dictionary<(int, int), int>();
            //return Dfs(0, s.Length - 1);

            //int Dfs(int left, int right)
            //{
            //    if (left >= right)
            //        return 0;
            //    if (dict.ContainsKey((left, right)))
            //        return dict[(left, right)];

            //    if (s[left] != s[right])
            //        return dict[(left, right)] = 1 + Math.Min(Dfs(left + 1, right), Dfs(left, right - 1));

            //    return dict[(left, right)] = Dfs(left + 1, right - 1);
            //}

            //Not Mine:
            int n = s.Length;
            int[,] dp = new int[n + 1, n + 1];
            for (int i = 0; i < n; ++i)
            for (int j = 0; j < n; ++j)
                dp[i + 1, j + 1] = s[i] == s[n - 1 - j] ? dp[i,j] + 1 : Math.Max(dp[i,j + 1], dp[i + 1,j]);
            return n - dp[n, n];
        }
    }
}
