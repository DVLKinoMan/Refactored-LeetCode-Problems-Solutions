using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Word Search (Mine)
        /// </summary>
        /// <param name="board"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool Exist(char[][] board, string word)
        {
            int m = board.Length, n = board[0].Length;
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (ExistsWord(i, j, 0, new HashSet<(int, int)>()))
                    return true;

            return false;

            bool ExistsWord(int i, int j, int wordIndex, HashSet<(int, int)> visited)
            {
                if (i >= m || j >= n || i < 0 || j < 0 || visited.Contains((i, j)) || board[i][j] != word[wordIndex])
                    return false;
                if (wordIndex == word.Length - 1)
                    return true;
                visited.Add((i, j));

                bool res = ExistsWord(i + 1, j, wordIndex + 1, visited) ||
                           ExistsWord(i - 1, j, wordIndex + 1, visited) ||
                           ExistsWord(i, j + 1, wordIndex + 1, visited) ||
                           ExistsWord(i, j - 1, wordIndex + 1, visited);

                visited.Remove((i, j));

                return res;
            }
        }
    }
}