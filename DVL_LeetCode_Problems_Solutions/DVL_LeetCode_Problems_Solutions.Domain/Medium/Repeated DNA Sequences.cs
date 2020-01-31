using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Repeated DNA Sequences (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static IList<string> FindRepeatedDnaSequences(string s)
        {
            var dict = new Dictionary<string, int>();

            for (int i = 0; i <= s.Length - 10; i++)
            {
                var str = s.Substring(i, 10);
                dict[str] = dict.ContainsKey(str) ? dict[str] + 1 : 1;
            }

            return dict.Where(str => str.Value > 1)
                       .Select(str => str.Key)
                       .ToList();
        }
    }
}
