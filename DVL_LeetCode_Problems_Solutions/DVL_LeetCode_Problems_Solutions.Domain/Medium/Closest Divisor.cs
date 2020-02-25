using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Closest Divisor (Not Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[] ClosestDivisors(int num)
        {
            int num1 = num + 1, num2 = num + 2, dist = int.MaxValue;

            int[] result = new int[2];
            for (int i = (int) Math.Sqrt(num2); i >= 1; i--)
                if (num2 % i == 0)
                {
                    result = new[] {i, num2 / i};
                    dist = num2 / i - i;
                    break;
                }

            for (int i = (int) Math.Sqrt(num1); i >= 1; i--)
                if (num1 % i == 0)
                {
                    if (num1 / i - i < dist)
                        result = new [] {i, num1 / i};
                    break;
                }

            return result;
        }
    }
}