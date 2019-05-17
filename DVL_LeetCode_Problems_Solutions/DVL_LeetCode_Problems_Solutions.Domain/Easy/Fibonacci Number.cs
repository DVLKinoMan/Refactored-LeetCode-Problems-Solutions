namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Fibonacci Number
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int Fib(int N)
        {
            if (N == 0)
                return 0;
            if (N == 1)
                return 1;

            return Fib(N - 2) + Fib(N - 1);
        }
    }
}
