using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Valid Anagram (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var dict1 = GetDict(s);
            var dict2 = GetDict(t);

            foreach (var keyVal in dict1)
                if (!dict2.ContainsKey(keyVal.Key) || dict2[keyVal.Key] != keyVal.Value)
                    return false;

            return true;

            Dictionary<char, int> GetDict(string str)
            {
                var dict = new Dictionary<char, int>();
                foreach (var ch in str)
                {
                    if (dict.ContainsKey(ch))
                        dict[ch]++;
                    else dict.Add(ch, 1);
                }

                return dict;
            }
        }
    }
}
