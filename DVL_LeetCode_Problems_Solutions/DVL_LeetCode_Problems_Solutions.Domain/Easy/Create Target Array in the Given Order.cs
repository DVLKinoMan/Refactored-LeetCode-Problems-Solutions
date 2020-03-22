using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Create Target Array in the Given Order (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            var target = new List<int>();

            for (int i = 0; i < nums.Length; i++)
                target.Insert(index[i], nums[i]);

            return target.ToArray();
        }
    }
}