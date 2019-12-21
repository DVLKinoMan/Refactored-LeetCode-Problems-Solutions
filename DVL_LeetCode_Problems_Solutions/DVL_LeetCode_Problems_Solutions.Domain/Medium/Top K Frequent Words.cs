using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Top K Frequent Words (Mine)
        /// </summary>
        /// <param name="words"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static IList<string> TopKFrequent(string[] words, int k)
        {
            var dict = new Dictionary<string, int>();
            foreach (var w in words)
                dict[w] = dict.ContainsKey(w) ? dict[w] + 1 : 1;

            return dict.OrderByDescending(d => d.Value)
                       .ThenBy(d => d.Key)
                       .Take(k)
                       .Select(d => d.Key)
                       .ToList();
        }
    }
}
