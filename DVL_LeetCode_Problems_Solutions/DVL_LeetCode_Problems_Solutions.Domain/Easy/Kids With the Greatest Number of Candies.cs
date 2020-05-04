using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Kids With the Greatest Number of Candies (Mine)
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="extraCandies"></param>
        /// <returns></returns>
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            bool[] arr = new bool [candies.Length];
            for (int i = 0; i < candies.Length; i++)
                arr[i] = candies[i] + extraCandies >= max;

            return arr;
        }
    }
}