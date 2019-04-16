using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    /// <summary>
    /// Edit Distance (Not mine Solution)
    /// </summary>
    partial class ProblemSolver
    {
        public static int MinDistance(string word1, string word2)
        {
            int[,] matrix = new int[word1.Length + 1, word2.Length + 1];
            for (int i = 0; i <= word1.Length; i++)
                matrix[i, 0] = i;
            for (int j = 0; j <= word2.Length; j++)
                matrix[0, j] = j;

            for (int i = 1; i <= word1.Length; i++)
            {
                for (int j = 1; j <= word2.Length; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                        matrix[i, j] = matrix[i - 1, j - 1];
                    else matrix[i,j]=Math.Min(matrix[i - 1, j - 1], Math.Min(matrix[i - 1, j], matrix[i, j - 1])) + 1;
                }
            }

            return matrix[word1.Length, word2.Length];
        }
    }
}
