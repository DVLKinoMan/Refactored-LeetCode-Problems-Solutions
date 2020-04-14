using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Pairs of Songs With Total Durations Divisible by 60 (Mine)
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int NumPairsDivisibleBy60(int[] time) 
        {
            var dict = new Dictionary<int, int>();
            int count = 0;
            foreach (var t in time)
            {
                int num = 60 - t % 60;
                if (dict.ContainsKey(t%60))
                    count += dict[t%60];
                dict[num] = dict.ContainsKey(num) ? dict[num] + 1 : 1;
            }

            return count;
        }
    }
}