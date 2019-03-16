using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSovler
    {
        /// <summary>
        /// Divide Two Integers
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == 1)
                return int.MinValue;

            long dividendAbs = Math.Abs((long)dividend);
            long divisorAbs = Math.Abs((long)divisor);

            int result = 0;
            while (dividendAbs >= divisorAbs)
            {
                long y = divisorAbs;
                int count = 1;
                while (dividendAbs >= (y << 1))
                {
                    y <<= 1;
                    count <<= 1;
                }
                dividendAbs -= y;
                result += count;
            }

            if (result < 0)
                return int.MaxValue;

            if (dividend < 0 ^ divisor < 0)
            {
                int temp = result;
                result -= temp;
                result -= temp;
            }

            return result;
        }
    }
}
