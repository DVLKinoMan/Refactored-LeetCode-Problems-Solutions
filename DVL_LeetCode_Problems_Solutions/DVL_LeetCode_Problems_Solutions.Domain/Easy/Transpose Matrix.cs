namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Transpose Matrix (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[][] Transpose(int[][] A)
        {
            int M = A.Length, N = A[0].Length;
            int[][] B = new int[N][];
            for (int j = 0; j < N; j++)
            {
                B[j] = new int[M];
                for (int i = 0; i < M; i++)
                    B[j][i] = A[i][j];
            }

            return B;
        }
    }
}
