using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Shortest Palindrome (Mine - slow)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ShortestPalindrome(string s)
        {
            int palindromeLastIndex = 0;
            for (int i = s.Length - 1; i > 1; i--)
            {
                if (!IsPalindromeFromBegging(i)) 
                    continue;
                palindromeLastIndex = i;
                break;
            }

            var builder = new StringBuilder();
            for (int i = s.Length-1; i > palindromeLastIndex; i--)
                builder.Append(s[i]);

            builder.Append(s);
            return builder.ToString();

            bool IsPalindromeFromBegging(int j)
            {
                for (int i1 = 0; i1 < (j + 1) / 2; i1++)
                    if (s[i1] != s[j - i1])
                        return false;

                return true;
            }
        }
    }
}
