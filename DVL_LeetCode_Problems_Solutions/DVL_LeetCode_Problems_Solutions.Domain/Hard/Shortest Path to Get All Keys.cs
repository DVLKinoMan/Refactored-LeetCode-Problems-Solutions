using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Shortest Path to Get All Keys (Not Working)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int ShortestPathAllKeys(string[] grid)
        {
            int m = grid.Length, n = grid[0].Length, stRow = 0, stCol = 0, keysCount = 0, min = int.MaxValue;

            for (int i2 = 0; i2 < m; i2++)
                for (int j2 = 0; j2 < n; j2++)
                {
                    if (grid[i2][j2] == '@')
                        (stRow, stCol) = (i2, j2);
                    if (char.IsLower(grid[i2][j2]))
                        keysCount++;
                }

            Dfs(stRow, stCol, 0, new Dictionary<(int, int), int>(), new HashSet<char>());

            return min == int.MaxValue ? -1 : min;

            void Dfs(int i, int j, int currLen, Dictionary<(int, int), int> visited, HashSet<char> keys)
            {
                AddToVisited(i, j);
                if (char.IsLower(grid[i][j]))
                    keys.Add(grid[i][j]);

                if (keysCount == keys.Count)
                    min = Math.Min(min, currLen);

                //Up
                if (i != 0 && CanVisit(i - 1, j))
                    Dfs(i - 1, j, currLen + 1, visited, keys);

                //Down
                if (i != m - 1 && CanVisit(i + 1, j))
                    Dfs(i + 1, j, currLen + 1, visited, keys);

                //Left
                if (j != 0 && CanVisit(i, j - 1))
                    Dfs(i, j - 1, currLen + 1, visited, keys);

                //Right
                if (j != n - 1 && CanVisit(i, j + 1))
                    Dfs(i, j + 1, currLen + 1, visited, keys);

                visited[(i, j)]--;
                if (char.IsLower(grid[i][j]))
                    keys.Remove(grid[i][j]);

                bool CanVisit(int i1, int j1) =>
                    (!visited.ContainsKey((i1, j1)) || visited[(i1, j1)] <= 4) && grid[i1][j1] != '#' &&
                    (!char.IsUpper(grid[i1][j1]) || keys.Contains(char.ToLower(grid[i1][j1])));

                void AddToVisited(int i3, int j3)
                {
                    if (visited.ContainsKey((i3, j3)))
                        visited[(i3, j3)]++;
                    else visited.Add((i3,j3), 1);
                }
            }
        }
    }
}
