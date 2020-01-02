using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Isomorphic Strings (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="isFirst"></param>
        /// <returns></returns>
        public static bool IsIsomorphic(string s, string t, bool isFirst = true)
        {
            var dict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], t[i]);
                else if (dict[s[i]] != t[i])
                    return false;
            }

            return !isFirst || IsIsomorphic(t, s, false);
        }
    }
}
