using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Get Equal Substrings Within Budget (Not Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="maxCost"></param>
        /// <returns></returns>
        public static int EqualSubstring(string s, string t, int maxCost)
        {
            int n = s.Length, i = 0, j;
            for (j = 0; j < n; ++j)
            {
                maxCost -= Math.Abs(s[j] - t[j]);
                if (maxCost < 0)
                {
                    maxCost += Math.Abs(s[i] - t[i]);
                    ++i;
                }
            }
            return j - i;
        }
    }
}
