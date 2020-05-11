namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Count Triplets That Can Form Two Arrays of Equal XOR (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int CountTriplets(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int xor = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    xor ^= arr[j];
                    if (xor == 0)
                        count += j - i;
                }
            }

            return count;
        }
    }
}