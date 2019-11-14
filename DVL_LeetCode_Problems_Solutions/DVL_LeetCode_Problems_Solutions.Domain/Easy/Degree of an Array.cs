using System;
using System.Collections.Generic;

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
            Dictionary<int, int> firstIndexes = new Dictionary<int, int>(), numCounts = new Dictionary<int, int>();
            int degree = 0, minLen = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if(!firstIndexes.ContainsKey(nums[i]))
                    firstIndexes.Add(nums[i], i);

                if (numCounts.ContainsKey(nums[i]))
                    numCounts[nums[i]]++;
                else numCounts.Add(nums[i], 1);

                if (degree < numCounts[nums[i]])
                {
                    degree = numCounts[nums[i]];
                    minLen = i - firstIndexes[nums[i]] + 1;
                }
                else if (numCounts[nums[i]] == degree)
                    minLen = Math.Min(minLen, i - firstIndexes[nums[i]] + 1);
            }

            return minLen;
        }
    }
}
