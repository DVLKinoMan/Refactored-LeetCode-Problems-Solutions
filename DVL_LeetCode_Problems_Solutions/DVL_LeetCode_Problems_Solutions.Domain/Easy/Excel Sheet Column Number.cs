using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Excel Sheet Column Number (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int TitleToNumber(string s)
        {
            int res = 0, mul = (int)Math.Pow(26, s.Length - 1);
            for (int i = 0; i < s.Length; i++)
            {
                res += (s[i] - 'A' + 1) * mul;
                mul /= 26;
            }

            return res;
        }
    }
}
