using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Lucky Integer in an Array (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindLucky(int[] arr)
        {
            var counts = new int[501];
            foreach (var num in arr)
                counts[num]++;

            int res = -1;
            for (int i = 1; i < counts.Length; i++)
                if (counts[i] == i)
                    res = Math.Max(res, counts[i]);

            return res;
        }
    }
}