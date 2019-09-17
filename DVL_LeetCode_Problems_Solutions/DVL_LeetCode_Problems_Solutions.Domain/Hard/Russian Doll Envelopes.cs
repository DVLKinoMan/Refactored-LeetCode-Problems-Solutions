using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Russian Doll Envelopes (Mine)
        /// </summary>
        /// <param name="envelopes"></param>
        /// <returns></returns>
        public static int MaxEnvelopes(int[][] envelopes)
        {
            if (envelopes.Length == 0)
                return 0;

            var heights = envelopes.OrderBy(env => env[0]).ThenByDescending(env => env[1]).Select(env => env[1]).ToArray();
            int[] lis = new int[heights.Length];
            lis[0] = 1;
            for (int i = 1; i < heights.Length; i++)
            {
                int max = -1;
                for (int k = 0; k < i; k++)
                    if (heights[i] > heights[k] && lis[k] + 1 > max)
                        max = lis[k] + 1;
                lis[i] = max == -1 ? 1 : max;
            }

            return lis.Max();
        }
    }
}
