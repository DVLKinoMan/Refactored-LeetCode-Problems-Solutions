using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Word Search II (Mine)
        /// </summary>
        /// <param name="board"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static IList<string> FindWords(char[][] board, string[] words)
        {
            int m = board.Length, n = board[0].Length;
            var list = new List<string>();
            foreach (var word in words)
            {
                bool isInBoard = false;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        if (Dfs(word, 0, i, j, new HashSet<(int, int)>()))
                        {
                            list.Add(word);
                            isInBoard = true;
                            break;
                        }

                    if (isInBoard)
                        break;
                }
            }

            return list;

            bool Dfs(string w, int charIndex, int i, int j, HashSet<(int, int)> previousCoords)
            {
                if (previousCoords.Contains((i, j)) || i >= m || i < 0 || j >= n || j < 0 ||
                    w[charIndex] != board[i][j])
                    return false;

                charIndex++;
                if (charIndex == w.Length)
                    return true;
                previousCoords.Add((i, j));

                bool result = Dfs(w, charIndex, i + 1, j, previousCoords) ||
                              Dfs(w, charIndex, i, j + 1, previousCoords) ||
                              Dfs(w, charIndex, i - 1, j, previousCoords) ||
                              Dfs(w, charIndex, i, j - 1, previousCoords);

                previousCoords.Remove((i, j));

                return result;
            }
        }
    }
}
