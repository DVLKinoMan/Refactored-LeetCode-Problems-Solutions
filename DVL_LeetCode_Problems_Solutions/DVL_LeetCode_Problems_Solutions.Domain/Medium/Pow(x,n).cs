using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Pow(x, n) (My Solution)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double MyPow(double x, int n)
        {
            return MyPowHelper(x, n, 1);
        }

        private static double MyPowHelper(double x, int n, double x2)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return x * x2;
            if (n == -1)
                return 1 / (x * x2);

            return MyPowHelper(x * x, n / 2, (n != int.MinValue && Math.Abs(n) % 2 == 1 ? x * x2 : x2));
        }
    }
}
