using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid Parenthesis String (Not Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckValidString(string s)
        {
            int low = 0,high = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    low++;
                    high++;
                }
                else if (s[i] == ')')
                {
                    low = Math.Max(low - 1, 0);
                    high--;
                }
                else
                {
                    low = Math.Max(low - 1, 0);
                    high++;
                }

                if (high < 0)
                    return false;
            }

            return low == 0;
        }
    }
}
