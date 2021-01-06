using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Consecutive Sequence (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var num in nums)
                set.Add(num);

            int max = 0;
            foreach (var num in nums)
                if (!set.Contains(num - 1))
                {
                    int n = num;
                    int count = 0;
                    while (set.Contains(n++))
                        count++;
                    max = Math.Max(max, count);
                }

            return max;
        }
    }
}
