using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Number of Balloons (Mine)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static int MaxNumberOfBalloons(string text)
        {
            var dic = new Dictionary<char, int>()
            {
                {'b', 1 },
                {'a', 1 },
                {'l' , 2},
                {'o', 2 },
                {'n', 1 }
            };

            var dic2 = new Dictionary<char, int>();
            foreach (var ch in text)
            {
                if (dic2.ContainsKey(ch))
                    dic2[ch]++;
                else dic2.Add(ch, 1);
            }

            int count = int.MaxValue;
            foreach (var keyVal in dic)
            {
                if (!dic2.ContainsKey(keyVal.Key))
                    return 0;

                count = Math.Min(count, dic2[keyVal.Key] / keyVal.Value);
            }

            return count;
        }

        /// <summary>
        /// Reverse Substrings Between Each Pair of Parentheses (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string ReverseParentheses(string s, int index = 0)
        {
            int count = 0;
            return ReverseParenthesesHelper(s, ref count, index);
        }

        private static string ReverseParenthesesHelper(string s,  ref int count, int index = 0)
        {
            var str = new StringBuilder();
            for (int i = index; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    count++;
                    int count2 = 0;
                    string s2 = ReverseParenthesesHelper(s, ref count2, i + 1);
                    str.Append(s2);
                    i += s2.Length + count2;
                    count += count2;
                }
                else if (s[i] == ')')
                {
                    count++;
                    return new string(str.ToString().Reverse().ToArray());
                }
                else str.Append(s[i]);
            }

            return str.ToString();
        }
    }
}
