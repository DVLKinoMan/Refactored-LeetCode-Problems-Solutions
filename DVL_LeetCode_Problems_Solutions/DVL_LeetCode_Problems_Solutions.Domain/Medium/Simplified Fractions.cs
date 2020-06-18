using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Simplified Fractions (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> SimplifiedFractions(int n)
        {
            var list = new List<string>();
            var set = new HashSet<double>();

            for (int i = 1; i < n; i++)
            for (int j = i + 1; j <= n; j++)
                if (set.Add((double) i / j))
                    list.Add($"{i}/{j}");

            return list;
        }
    }
}