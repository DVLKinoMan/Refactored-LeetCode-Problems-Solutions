using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid_Parentheses
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsValid(string s)
        {
            var dic = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            var openBrackets = new List<char>();
            foreach (var ch in s)
            {
                if (!dic.ContainsKey(ch))
                {
                    if (openBrackets.Count == 0 || dic[openBrackets.Last()] != ch)
                        return false;
                    else openBrackets.RemoveAt(openBrackets.Count - 1);
                }
                else openBrackets.Add(ch);
            }

            return openBrackets.Count == 0;
        }
    }
}
