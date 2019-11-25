using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Ways to Stay in the Same Place After Some Steps (Not Mine - My implmentation)
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="arrLen"></param>
        /// <returns></returns>
        public static int NumWays(int steps, int arrLen)
        {
            var dp = new Dictionary<(int,int), int>();
            int mod = (int)Math.Pow(10, 9) + 7;

            return Dp(0, steps);

            int Dp(int pos, int steps2)
            {
                if (steps2 == 0 && pos == 0)
                    return 1;
                if (pos >= arrLen || pos < 0 || steps2 <= 0)
                    return 0;
                if (dp.ContainsKey((pos,  steps2)))
                    return dp[(pos,  steps2)];
                dp.Add((pos,  steps2),
                    ((Dp(pos + 1, steps2 - 1) + Dp(pos - 1, steps2 - 1)) % mod + Dp(pos, steps2 - 1)) % mod);

                return dp[(pos, steps2)];
            }
        }
    }
}
