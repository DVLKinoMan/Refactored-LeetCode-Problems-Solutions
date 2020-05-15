namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Digit One (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountDigitOne(int n)
        {
            int ones = 0;
            for (long m = 1; m <= n; m *= 10)
                ones += (int) ((n / m + 8) / 10 * m + (n / m % 10 == 1 ? 1 : 0) * (n % m + 1));
            return ones;
        }
    }
}