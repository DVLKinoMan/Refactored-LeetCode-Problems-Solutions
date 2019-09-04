using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sum of Square Numbers (Not Mine)
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool JudgeSquareSum(int c)
        {
            var set = new HashSet<int>();

            for (int i = 0; i <= Math.Sqrt(c); i++)
            {
                set.Add(i * i);
                if (set.Contains(c - i * i))
                    return true;
            }
            return false;
        }
    }
}
