using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Delete Operation for Two Strings (Mine)
        /// </summary>
        /// <param name="word1"></param>
        /// <param name="word2"></param>
        /// <returns></returns>
        public static int MinDistance2(string word1, string word2)
        {
            int[,] m = new int[word1.Length + 1, word2.Length + 1];
            for (int i = 1; i <= word1.Length; i++)
                for (int j = 1; j <= word2.Length; j++)
                    m[i, j] = word1[i - 1] == word2[j - 1] ? m[i - 1, j - 1] + 1 : Math.Max(m[i - 1, j], m[i, j - 1]);
            int res = m[word1.Length, word2.Length];
            return word1.Length - res + word2.Length - res;
        }
    }
}
