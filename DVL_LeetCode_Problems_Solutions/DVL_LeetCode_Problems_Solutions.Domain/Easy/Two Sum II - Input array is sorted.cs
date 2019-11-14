using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Two Sum II - Input array is sorted (Mine)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] numbers, int target)
        {
            var leftToTargetNumberIndexes = new Dictionary<int,int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (leftToTargetNumberIndexes.ContainsKey(target - numbers[i]))
                    return new int[] {leftToTargetNumberIndexes[target - numbers[i]], i + 1};
                if (!leftToTargetNumberIndexes.ContainsKey(numbers[i]))
                    leftToTargetNumberIndexes.Add(numbers[i], i + 1);
            }

            return Array.Empty<int>();
        }
    }
}
