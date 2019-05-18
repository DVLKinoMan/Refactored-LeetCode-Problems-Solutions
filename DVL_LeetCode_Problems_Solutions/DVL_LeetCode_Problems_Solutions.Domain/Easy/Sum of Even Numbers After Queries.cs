namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sum of Even Numbers After Queries (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            var result = new int[queries.Length];

            int evensSum = 0;
            for (int i = 0; i < A.Length; i++)
                if (A[i] % 2 == 0)
                    evensSum += A[i];

            for (int i = 0; i < queries.Length; i++)
            {
                var q = queries[i];
                int prevValue = A[q[1]];
                A[q[1]] += q[0];
                if (prevValue % 2 != 0)
                    evensSum += A[q[1]] % 2 == 0 ? A[q[1]] : 0;
                else
                {
                    evensSum -= prevValue;
                    evensSum += A[q[1]] % 2 == 0 ? A[q[1]] : 0;
                }

                result[i] = evensSum;
            }

            return result;
        }
    }
}
