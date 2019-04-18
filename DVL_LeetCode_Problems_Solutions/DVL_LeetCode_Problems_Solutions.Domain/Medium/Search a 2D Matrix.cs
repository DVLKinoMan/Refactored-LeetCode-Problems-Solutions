namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Search a 2D Matrix (My Solution)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
                return false;

            int m = matrix.Length, n = matrix[0].Length;
            int i = 0;
            while (i != m - 1 && target > matrix[i][0])
                i++;

            if (matrix[i][0] == target)
                return true;

            if (!(i == m - 1 && target > matrix[i][0]))
                i--;

            for (int j = 0; j < n; j++)
                if (matrix[i][j] == target)
                    return true;

            return false;
        }
    }
}
