namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Counting Bits (Not Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[] CountBits(int num)
        {
            int[] arr = new int[num + 1];
            for (int i = 1; i <= num; i++)
                arr[i] = arr[i >> 1] + (i & 1);
            return arr;
        }
    }
}
