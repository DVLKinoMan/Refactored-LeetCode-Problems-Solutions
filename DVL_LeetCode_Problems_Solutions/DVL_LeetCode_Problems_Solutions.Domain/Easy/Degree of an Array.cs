using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Degree of an Array (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindShortestSubArray(int[] nums)
        {
            var dict = new Dictionary<int,List<int>>();
            for (int i = 0; i< nums.Length;i++)
            {
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]].Add(i);
                else dict.Add(nums[i], new List<int> {i});
            }

            int maxDegree = dict.Max(d=>d.Value.Count);
            var keys = dict.Where(d => d.Value.Count == maxDegree).Select(d => d.Key).ToList();
            int minLen = int.MaxValue;
            foreach (var key in keys)
                minLen = Math.Min(minLen, dict[key][dict[key].Count - 1] - dict[key][0] + 1);

            return minLen;
        }
    }
}
