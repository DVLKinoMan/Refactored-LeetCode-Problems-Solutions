using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Not Mine
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int LongestArithSeqLength(int[] A)
        {
            if (A.Length == 1) return 1;

            var diffs = new Dictionary<(int, int), int>(A.Length * A.Length);

            var currentMax = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    var diff = A[j] - A[i];

                    var key1 = (diff, j);
                    var key2 = (diff, i);

                    diffs.TryGetValue(key1, out int maxDiffJ);
                    diffs.TryGetValue(key2, out int maxDiffI);

                    var newMax = Math.Max(maxDiffJ, maxDiffI + 1);
                    diffs[key1] = newMax;

                    currentMax = Math.Max(currentMax, newMax);
                }
            }

            //  var see = diffs.OrderByDescending(x => x.Value).ToList();

            var maxDiff = currentMax + 1;
            return maxDiff;
        }
    }
}
