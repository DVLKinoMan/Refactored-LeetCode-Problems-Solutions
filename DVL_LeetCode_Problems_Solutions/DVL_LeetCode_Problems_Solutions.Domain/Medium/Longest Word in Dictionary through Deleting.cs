using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Word in Dictionary through Deleting (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string FindLongestWord(string s, IList<string> d)
        {
            string res = string.Empty;
            foreach (var st in d)
                if (Can(st) && 
                    (res.Length < st.Length || (res.Length == st.Length && string.Compare(res, st) > 0)))
                    res = st;

            return res;

            bool Can(string str)
            {
                int i = 0, j = 0;
                while (i < s.Length && j < str.Length)
                {
                    if (s[i] == str[j])
                        i++;
                    j++;
                }

                return i == s.Length;
            }
        }
    }
}