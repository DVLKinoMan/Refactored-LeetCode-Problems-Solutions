namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Length of Repeated Subarray (My Solution)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int FindLength(int[] A, int[] B)
        {
            int max = 0;
            int[,] matrix = new int[A.Length + 1, B.Length + 1];
            for (int i = 0; i < A.Length; i++)
            for (int j = 0; j < B.Length; j++)
                if (A[i] == B[j])
                {
                    matrix[i + 1, j + 1] = matrix[i, j] + 1;
                    if (matrix[i + 1, j + 1] > max)
                        max = matrix[i + 1, j + 1];
                }

            return max;
        }
    }
}
