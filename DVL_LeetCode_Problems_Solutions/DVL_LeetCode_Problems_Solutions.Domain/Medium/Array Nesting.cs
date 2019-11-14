using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver 
    {
        /// <summary>
        /// Array Nesting (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int ArrayNesting(int[] nums)
        {
            int maxLen = 0;
            var visitedIndexes = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
                if (!visitedIndexes.Contains(i))
                    maxLen = Math.Max(maxLen, dfs(i, new HashSet<int>(), visitedIndexes));

            return maxLen;

            int dfs(int index, ISet<int> set, ISet<int> vSet)
            {
                if (!set.Add(nums[index]))
                    return set.Count;
                visitedIndexes.Add(index);
                return dfs(nums[index], set, vSet);
            }
        }
    }
}
