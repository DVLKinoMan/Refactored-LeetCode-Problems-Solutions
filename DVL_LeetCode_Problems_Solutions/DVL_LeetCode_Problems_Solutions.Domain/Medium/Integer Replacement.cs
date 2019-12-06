using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Integer Replacement (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="opCount"></param>
        /// <returns></returns>
        public static int IntegerReplacement(int n, int opCount = 0)
        {
            switch (n)
            {
                case int.MaxValue:
                    return 32;
                case 1:
                    return opCount;
                default:
                    opCount++;
                    return (n & 1) == 0 ? IntegerReplacement(n >> 1, opCount) :
                        Math.Min(IntegerReplacement(n - 1, opCount), IntegerReplacement(n + 1, opCount));
            }
        }
    }
}
