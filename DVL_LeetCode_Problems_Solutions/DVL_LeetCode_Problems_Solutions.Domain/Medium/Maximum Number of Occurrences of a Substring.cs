﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Number of Occurrences of a Substring (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="maxLetters"></param>
        /// <param name="minSize"></param>
        /// <param name="maxSize"></param>
        /// <returns></returns>
        public static int MaxFreq(string s, int maxLetters, int minSize, int maxSize)
        {
            //My version:
            //var dict = new Dictionary<string, int>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    var set = minSize > 1 && i + minSize <= s.Length
            //        ? new HashSet<char>(s.Substring(i, minSize - 1))
            //        : new HashSet<char>();
            //    for (int len = minSize; len <= maxSize; len++)
            //        if (i + len <= s.Length)
            //        {
            //            set.Add(s[i + len - 1]);
            //            if (set.Count <= maxLetters)
            //            {
            //                var str = s.Substring(i, len);
            //                dict[str] = dict.ContainsKey(str) ? dict[str] + 1 : 1;
            //            }
            //            else break;
            //        }
            //}

            //return dict.Any() ? dict.Max(d => d.Value) : 0;

            //Not mine:
            int start = 0, result = 0;
            var count = new Dictionary<char, int>();
            var occurence = new Dictionary<string, int> ();        
            for (int i = 0; i < s.Length; i++)         
            {
                count[s[i]] = count.ContainsKey(s[i]) ? count[s[i]] + 1 : 1;
                if (i - start + 1 > minSize)                  
                {
                    if (--count[s[start]] == 0)        
                        count.Remove(s[start]);
                    start++;
                }

                if (i - start + 1 == minSize && count.Count <= maxLetters)
                {
                    var str = s.Substring(start, i - start + 1);
                    occurence[str] = occurence.ContainsKey(str) ? occurence[str] + 1 : 1;
                    result = Math.Max(result, occurence[str]);
                }
            }

            return result;
        }
    }
}
