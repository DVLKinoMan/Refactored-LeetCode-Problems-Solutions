using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find and Replace Pattern (Mine)
        /// </summary>
        /// <param name="words"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var list = new List<string>();
            foreach (var word in words)
            {
                var dic = new Dictionary<char, char>();
                var dic2 = new Dictionary<char, char>();
                bool validWord = true;
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (dic.ContainsKey(pattern[i]))
                    {
                        if (dic[pattern[i]] != word[i])
                        {
                            validWord = false;
                            break;
                        }
                    }
                    else if (dic2.ContainsKey(word[i]))
                    {
                        if (dic2[word[i]] != pattern[i])
                        {
                            validWord = false;
                            break;
                        }
                    }
                    else
                    {
                        dic.Add(pattern[i], word[i]);
                        dic2.Add(word[i], pattern[i]);
                    }
                }
                if (validWord)
                    list.Add(word);
            }

            return list;
        }
    }
}
