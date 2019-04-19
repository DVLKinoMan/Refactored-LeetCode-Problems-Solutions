namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Search a 2D Matrix II (My Solution)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            int m = matrix.GetLength(0), n = matrix.GetLength(1);
            if (m == 0 || n == 0)
                return false;
            return IsInThisRectangle(matrix, target, 0, 0, m - 1, n - 1);
        }

        private static bool IsInThisRectangle(int[,] matrix, int target, int starti, int startj, int endi, int endj)
        {
            int i = starti + (endi - starti) / 2;
            int j = startj + (endj - startj) / 2;
            if (matrix[i, j] == target)
                return true;

            if (matrix[i, j] > target)
                return (i != starti && IsInThisRectangle(matrix, target, starti, startj, i - 1, endj)) ||
                       (j != startj && IsInThisRectangle(matrix, target, i, startj, endi, j - 1));

            return (i != endi && IsInThisRectangle(matrix, target, i + 1, startj, endi, endj)) ||
                   (j != endj && IsInThisRectangle(matrix, target, starti, j + 1, i, endj));
        }

        /// <summary>
        /// Search a 2D Matrix II (Not mine)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool SearchMatrix2(int[,] matrix, int target)
        {
            int m = matrix.GetLength(0), n = matrix.GetLength(1);
            if (m == 0 || n == 0)
                return false;

            int row = 0, col = n - 1;
            while (col >= 0 && row < m)
            {
                if (matrix[row, col] == target)
                    return true;
                if (matrix[row, col] < target)
                    row++;
                else col--;
            }

            return false;
        }
    }
}
