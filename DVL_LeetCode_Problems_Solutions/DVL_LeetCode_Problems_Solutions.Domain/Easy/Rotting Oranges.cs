namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rotting Oranges (Not Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int OrangesRotting(int[][] grid)
        {
            int freshCount = 0, d = 0;
            for (int i = 0; i < grid.Length; ++i)
            for (int j = 0; j < grid[i].Length; ++j)
                if (grid[i][j] == 1) 
                    freshCount++;
            
            for (int old_fresh = freshCount; freshCount > 0; ++d, old_fresh = freshCount) {
                for (int i = 0; i < grid.Length; ++i)
                for (int j = 0; j < grid[i].Length; ++j)
                    if (grid[i][j] == d + 2)
                        freshCount -= Rot(i + 1, j, d) + Rot(i - 1, j, d) + 
                                      Rot(i, j + 1, d) + Rot(i, j - 1, d);
                if (freshCount == old_fresh) 
                    return -1;
            }
            
            return d;

            int Rot(int i, int j, int de)
            {
                if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] != 1)
                    return 0;
                grid[i][j] = de + 3;
                return 1;
            }
        }
    }
}