using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Filling Bookcase Shelves (Not Mine)
        /// </summary>
        /// <param name="books"></param>
        /// <param name="shelf_width"></param>
        /// <returns></returns>
        public static int MinHeightShelves(int[][] books, int shelf_width)
        {
            var dp = new int[books.Length + 1];
            dp[0] = 0;

            for (int i = 1; i <= books.Length; ++i)
            {
                int width = books[i - 1][0];
                int height = books[i - 1][1];
                dp[i] = dp[i - 1] + height;
                for (int j = i - 1; j > 0 && width + books[j - 1][0] <= shelf_width; --j)
                {
                    height = Math.Max(height, books[j - 1][1]);
                    width += books[j - 1][0];
                    dp[i] = Math.Min(dp[i], dp[j - 1] + height);
                }
            }
            return dp[books.Length];
        }
    }
}
