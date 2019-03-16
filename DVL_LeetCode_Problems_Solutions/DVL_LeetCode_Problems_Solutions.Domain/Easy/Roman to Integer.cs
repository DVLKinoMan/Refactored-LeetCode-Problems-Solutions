using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Roman_to_Integer
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToInt(string s)
        {
            int result = 0;

            var romanNumbers = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            var amountsInRoman = new List<char> { 'I', 'X', 'C' };

            for (int i = 0; i < s.Length; i++)
            {
                int index = amountsInRoman.IndexOf(s[i]);
                if (index >= 0 && i + 1 < s.Length && romanNumbers[s[i + 1]] > romanNumbers[s[i]])
                {
                    result += romanNumbers[s[i + 1]] - romanNumbers[s[i]];
                    i++;
                }
                else result += romanNumbers[s[i]];
            }

            return result;
        }
    }
}
