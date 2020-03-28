using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Four Divisors (Mine with hint)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SumFourDivisors(int[] nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                if (num == 1)
                    continue;
                int currSum = 1 + num, divisorsNum = 2;
                for (int divisor = 2; divisor * divisor <= num; divisor++)
                    if (num % divisor == 0)
                    {
                        divisorsNum++;
                        currSum += divisor;
                        if (num / divisor != divisor)
                        {
                            currSum += num / divisor;
                            divisorsNum++;
                        }

                        if (divisorsNum > 4)
                            break;
                    }

                if (divisorsNum == 4)
                    sum += currSum;
            }

            return sum;
        }
    }
}