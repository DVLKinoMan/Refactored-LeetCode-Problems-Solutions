using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Common Subsequence
        /// </summary>
        /// <param name="text1"></param>
        /// <param name="text2"></param>
        /// <returns></returns>
        public static int LongestCommonSubsequence(string text1, string text2)
        {
            int[,] matrix = new int[text1.Length + 1, text2.Length + 1];
            for (int i = 1; i <= text1.Length; i++)
            for (int j = 1; j <= text2.Length; j++)
            {
                int res = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                if (text1[i - 1] == text2[j - 1])
                    res = matrix[i - 1, j - 1] + 1;
                matrix[i, j] = res;
            }

            return matrix[text1.Length, text2.Length];
        }
    }
}
