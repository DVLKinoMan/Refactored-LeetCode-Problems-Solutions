using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Increment to Make Array Unique (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int MinIncrementForUnique(int[] A)
        {
            int count = 0, need = 0;
            Array.Sort(A);
            foreach (var a in A)
            {
                count += Math.Max(need - a, 0);
                need = Math.Max(need, a) + 1;
            }

            return count;
        }
    }
}
