using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Window Substring (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string MinWindow(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            foreach (var ch in t)
                dict[ch] = dict.ContainsKey(ch) ? dict[ch] + 1 : 1;

            int curBegin = 0,
                curEnd = 0,
                needCharactersCount = t.Length,
                begin = 0,
                end = int.MaxValue;
            while (curEnd < s.Length)
            {
                if (dict.ContainsKey(s[curEnd]))
                {
                    dict[s[curEnd]]--;
                    if (dict[s[curEnd]] >= 0)
                        needCharactersCount--;
                }

                while (needCharactersCount == 0)
                {
                    if (end - begin > curEnd - curBegin)
                    {
                        begin = curBegin;
                        end = curEnd;
                    }

                    if (dict.ContainsKey(s[curBegin]))
                    {
                        dict[s[curBegin]]++;
                        if (dict[s[curBegin]] > 0)
                            needCharactersCount++;
                    }

                    curBegin++;
                }

                curEnd++;
            }

            return end == int.MaxValue ? "" : s.Substring(begin, end - begin + 1);
        }
    }
}
