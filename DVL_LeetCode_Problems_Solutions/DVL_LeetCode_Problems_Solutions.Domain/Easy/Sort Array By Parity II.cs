namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sort Array By Parity II (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] SortArrayByParityII(int[] A)
        {
            int evenIndex = 0, oddIndex = 1;
            int[] res = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    res[evenIndex] = A[i];
                    evenIndex += 2;
                }
                else
                {
                    res[oddIndex] = A[i];
                    oddIndex += 2;
                }
            }

            return res;
        }
    }
}
