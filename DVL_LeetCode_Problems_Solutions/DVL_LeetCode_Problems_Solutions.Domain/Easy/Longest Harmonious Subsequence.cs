using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Harmonious Subsequence (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindLHS(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
                dict[num] = dict.ContainsKey(num) ? dict[num] + 1 : 1;

            int maxLength = 0;
            foreach (var keyValuePair in dict)
                if (dict.ContainsKey(keyValuePair.Key + 1))
                    maxLength = Math.Max(maxLength, dict[keyValuePair.Key] + dict[keyValuePair.Key + 1]);

            return maxLength;
        }
    }
}