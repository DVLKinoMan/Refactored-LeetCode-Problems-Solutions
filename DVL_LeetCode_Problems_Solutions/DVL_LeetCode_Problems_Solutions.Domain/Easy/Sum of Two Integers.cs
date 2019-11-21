using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sum of Two Integers (Mine)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int GetSum(int a, int b)
        {
            string strA = System.Convert.ToString(a, 2);
            string strB = System.Convert.ToString(b, 2);
            int aLen = strA.Length,
                bLen = strB.Length,
                len = Math.Max(aLen, bLen);
            int c = 0;
            var list = new List<int>();
            for (int i = 1; i <= len; i++)
            {
                int f = aLen - i >= 0 ? strA[aLen - i] - '0' : 0;
                int s = bLen - i >= 0 ? strB[bLen - i] - '0' : 0;
                list.Add(f ^ s ^ c);
                c = (f == 1 && s == 1) || ((f == 1 || s == 1) && c == 1) ? 1 : 0;
            }

            if (c == 1 && list.Count != 32)
                list.Add(1);

            list.Reverse();
            return System.Convert.ToInt32(string.Join("", list), 2);
        }
    }
}
