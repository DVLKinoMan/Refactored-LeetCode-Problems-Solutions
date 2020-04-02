using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Single Number (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumber(int[] nums) {
            int k = 0;
            foreach(var num in nums)
                k^=num;
            return k;
        }
        
        /// <summary>
        /// Happy Number (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsHappy(int n) 
        {
            var set = new HashSet<int>();
            while (set.Add(n) && n != 1)
                n = Sum(n);

            return n == 1;
            
            int Sum(int k)
            {
                int res = 0;
                while (k != 0)
                {
                    res += (int)Math.Pow(k % 10, 2);
                    k /= 10;
                }

                return res;
            }
        }
    }
}