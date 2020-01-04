using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Set Mismatch (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] FindErrorNums(int[] nums)
        {
            var set = new HashSet<int>();
            int missingNum = 0, twiceNum = 0;
            foreach (var num in nums)
                if (!set.Add(num))
                    twiceNum = num;
            for (int i = 1; i <= nums.Length; i++)
                if (!set.Contains(i))
                    missingNum = i;

            return new int[] {twiceNum, missingNum};
        }
    }
}
