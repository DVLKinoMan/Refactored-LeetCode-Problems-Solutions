namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// XOR Queries of a Subarray (Not Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public static int[] XorQueries(int[] arr, int[][] queries)
        {
            var result = new int[queries.Length];
            for (int i = 1; i < arr.Length; i++)
                arr[i] ^= arr[i - 1];

            for (int i = 0; i < queries.Length; i++)
                result[i] = queries[i][0] > 0 ? arr[queries[i][0] - 1] ^ arr[queries[i][1]] : arr[queries[i][1]];

            return result;
        }
    }
}
