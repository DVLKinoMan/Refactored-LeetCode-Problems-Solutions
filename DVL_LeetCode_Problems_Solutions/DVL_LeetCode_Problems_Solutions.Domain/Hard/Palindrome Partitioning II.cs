using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Palindrome Partitioning II (Not Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MinCut(string s)
        {
            var palindromes = new bool[s.Length, s.Length];
            var minCuts = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                int min = i;
                for (int j = 0; j <= i; j++)
                    if (s[i] == s[j] && (j + 1 > i - 1 || palindromes[j + 1, i - 1]))
                    {
                        palindromes[j, i] = true;
                        min = j == 0 ? 0 : Math.Min(min, minCuts[j - 1] + 1);
                    }

                minCuts[i] = min;
            }

            return minCuts[s.Length - 1];
        }
    }
}
