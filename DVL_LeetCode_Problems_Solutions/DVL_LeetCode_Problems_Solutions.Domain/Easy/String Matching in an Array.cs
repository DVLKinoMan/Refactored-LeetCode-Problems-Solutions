using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// String Matching in an Array (Mine)
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static IList<string> StringMatching(string[] words)
        {
            return words.Where(IsSubstringOfAny).ToList();

            bool IsSubstringOfAny(string str)
            {
                foreach (var word in words)
                {
                    if (str.Length >= word.Length)
                        continue;
                    if (word.Contains(str))
                        return true;
                }

                return false;
            }
        }
    }
}