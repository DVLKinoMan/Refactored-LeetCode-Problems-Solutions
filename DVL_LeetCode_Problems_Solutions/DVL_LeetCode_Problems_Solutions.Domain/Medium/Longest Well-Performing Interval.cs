using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Well-Performing Interval (Not Mine)
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public static int LongestWPI(int[] hours)
        {
            int res = 0, score = 0, n = hours.Length;
            var seen = new Dictionary<int,int>();
            for (int i = 0; i < n; ++i)
            {
                score += hours[i] > 8 ? 1 : -1;
                if (score > 0)
                {
                    res = i + 1;
                }
                else
                {
                    if(seen.ContainsKey(score))
                        seen.Add(score,i);
                    if (seen.ContainsKey(score - 1))
                        res = Math.Max(res, i - seen[score - 1]);
                }
            }
            return res;
        }
    }
}
