using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Palindrome (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LongestPalindrome(string s) 
        {
                var dict = new Dictionary<char, int>();
                foreach (var ch in s)
                    dict[ch] = dict.ContainsKey(ch) ? dict[ch] + 1 : 1;

                bool isOneOdd = false;
                int count = 0;
                foreach (var pair in dict)
                {
                    if (!isOneOdd && pair.Value % 2 == 1)
                    {
                        isOneOdd = true;
                        count++;
                    }

                    count += pair.Value % 2 == 0 ? pair.Value : pair.Value - 1;
                }

                return count;
        }
    }
}