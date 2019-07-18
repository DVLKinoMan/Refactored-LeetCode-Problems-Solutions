namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        /////  Toeplitz Matrix (Mine)
        ///// </summary>
        ///// <param name="matrix"></param>
        ///// <returns></returns>
        //public static bool IsToeplitzMatrix(int[][] matrix)
        //{
        //    int len = matrix.Length + matrix[0].Length;
        //    for (int count = 1; count < len; count++)
        //    {
        //        int i = matrix.Length - count < 0 ? 0 : matrix.Length - count;
        //        int j = matrix.Length - count < 0 ? Math.Abs(matrix.Length - count) : 0;
        //        int val = matrix[i][j];
        //        while (i < matrix.Length && j < matrix[0].Length)
        //        {
        //            if (matrix[i][j] != val)
        //                return false;
        //            i++;
        //            j++;
        //        }
        //    }

        //    return true;
        //}

        /// <summary>
        ///  Toeplitz Matrix (Not Mine)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static bool IsToeplitzMatrix(int[][] matrix)
        {
            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] != matrix[i - 1][j - 1]) return false;
                }
            }

            return true;
        }
    }
}
