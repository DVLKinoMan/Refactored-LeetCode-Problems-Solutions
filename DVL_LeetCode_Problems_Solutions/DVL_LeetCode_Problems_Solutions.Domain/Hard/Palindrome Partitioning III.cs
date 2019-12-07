using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Hard
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Palindrome Partitioning III (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int PalindromePartition(string s, int k)
        {
            var dict = new Dictionary<(int, int), int>();
            return Dfs(0, k);

            int Dfs(int i, int currK)
            {
                if (currK == 0)
                    return 0;
                if (dict.ContainsKey((i, currK)))
                    return dict[(i, currK)];

                int minCount = int.MaxValue;
                for (int len = currK == 1 ? s.Length - i : 1; len <= s.Length - i - (currK - 1); len++)
                    minCount = Math.Min(minCount, ChangesToMakePalindrome(i, len) + Dfs(i + len, currK - 1));

                dict.Add((i, currK), minCount);

                return minCount;
            }

            int ChangesToMakePalindrome(int i, int len)
            {
                int count = 0, limit = i + len / 2, end = i + len - 1;
                for (int j = i; j < limit; j++)
                    if (s[j] != s[end - (j - i)])
                        count++;
                return count;
            }
        }
    }
}
