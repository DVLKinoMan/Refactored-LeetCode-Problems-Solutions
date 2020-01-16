using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Enclaves (Not Working)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int NumEnclaves(int[][] A)
        {
            int m = A.Length, n = A[0].Length, count = 0;
            var visitedSet = new HashSet<(int, int)>();
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                int c = 0;
                if (A[i][j] != 0 && !visitedSet.Contains((i,j)) && !Dfs(i, j, ref c))
                    count += c;
            }

            return count;

            bool Dfs(int i, int j, ref int co)
            {
                if (A[i][j]==1 && (i == 0 || j == 0 || i == m - 1 || j == n - 1))
                    return true;
                if (i <= 0 || j <= 0 || i >= m - 1 || j >= n - 1 || A[i][j] == 0 || visitedSet.Contains((i, j)))
                    return false;

                visitedSet.Add((i, j));
                co++;

                return Dfs(i + 1, j, ref co) || Dfs(i, j + 1, ref co) || Dfs(i - 1, j, ref co) || Dfs(i, j - 1, ref co);
            }
        }
    }
}
