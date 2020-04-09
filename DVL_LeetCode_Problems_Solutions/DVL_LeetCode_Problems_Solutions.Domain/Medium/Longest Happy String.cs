using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Happy String (Not Mine)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string LongestDiverseString(int a, int b, int c)
        {
            return Generate(a, b, c, "a", "b", "c");
            string Generate(int a1, int b1, int c1, string aa, string bb, string cc)
            {
                if (a1 < b1)
                    return Generate(b1, a1, c1, bb, aa, cc);
                if (b1 < c1)
                    return Generate(a1, c1, b1, aa, cc, bb);
                if (b1 == 0)
                    return string.Join("", Enumerable.Repeat(aa, Math.Min(2, a1)));

                int use_a = Math.Min(2, a1), use_b = a1 - use_a >= b1 ? 1 : 0;
                return string.Join("", Enumerable.Repeat(aa, use_a)) + string.Join("", Enumerable.Repeat(bb, use_b))
                                                                     + Generate(a1 - use_a, b1 - use_b, c1, aa, bb, cc);
            }
        }
    }
}