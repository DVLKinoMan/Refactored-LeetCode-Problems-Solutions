namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Factorial Trailing Zeroes (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int TrailingZeroes(int n) => n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
    }
}
