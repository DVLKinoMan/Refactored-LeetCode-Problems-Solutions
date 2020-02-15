using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Number of Steps to Make Two Strings Anagram (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static int MinSteps(string s, string t)
        {
            var chars = new int[26];
            foreach (var ch in s)
                chars[ch - 'a']++;

            foreach (var ch in t)
                chars[ch - 'a']--;

            return Math.Max(Math.Abs(chars.Where(c => c < 0).Sum()), 
                            chars.Where(c=>c>0).Sum());
        }
    }
}