﻿namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Integer Break (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int IntegerBreak(int n)
        {
            if (n == 2)
                return 1;
            if (n == 3)
                return 2;
            
            int product = 1;
            while (n > 4)
            {
                product *= 3;
                n -= 3;
            }

            product *= n;
            return product;
        }
    }
}