using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Check if There is a Valid Path in a Grid (Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static bool HasValidPath(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            var dict = new Dictionary<int, ((int i, int j) firstDirection, (int i, int j) secondDirection)>()
            {
                [1] = ((0, -1), (0, 1)),
                [2] = ((-1, 0), (1, 0)),
                [3] = ((0, -1), (1, 0)),
                [4] = ((0, 1), (1, 0)),
                [5] = ((0, -1), (-1, 0)),
                [6] = ((0, 1), (-1, 0))
            };
            var visited = new HashSet<(int, int)>();
            return Dfs(0, 0);

            bool Dfs(int i, int j, (int, int)? prevLocation = null)
            {
                if (i < 0 || j < 0 || i >= m || j >= n || visited.Contains((i, j)))
                    return false;

                var directions = dict[grid[i][j]];
                bool prevLocIsNull = prevLocation == null;
                bool prevLocIsFromFirstDirection = !prevLocIsNull && Equal(prevLocation.Value, Sum((i, j), directions.firstDirection));
                bool prevLocIsFromSecondDirection =!prevLocIsNull && Equal(prevLocation.Value, Sum((i,j), directions.secondDirection));

                if (i == m - 1 && j == n - 1)
                    return prevLocIsNull || prevLocIsFromFirstDirection || prevLocIsFromSecondDirection;
                visited.Add((i, j));

                if (prevLocIsNull)
                    return Dfs(i + directions.firstDirection.i, j + directions.firstDirection.j, (i, j)) ||
                           Dfs(i + directions.secondDirection.i, j + directions.secondDirection.j, (i, j));

                return (prevLocIsFromSecondDirection &&
                        Dfs(i + directions.firstDirection.i, j + directions.firstDirection.j, (i, j))) ||
                       (prevLocIsFromFirstDirection &&
                        Dfs(i + directions.secondDirection.i, j + directions.secondDirection.j, (i, j)));
            }

            bool Equal((int i, int j) first, (int i, int j) second)
                => first.i == second.i && first.j == second.j;

            (int i, int j) Sum((int i, int j) direction, (int i, int j) location)
                => (location.i + direction.i, location.j + direction.j);
        }
    }
}