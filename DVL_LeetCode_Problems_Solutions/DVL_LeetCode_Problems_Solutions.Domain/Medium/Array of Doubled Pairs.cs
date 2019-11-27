using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Array of Doubled Pairs (Not Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static bool CanReorderDoubled(int[] A)
        {
            var dict = new SortedDictionary<int, int>();

            foreach (var a in A)
            {
                if (dict.ContainsKey(a))
                    dict[a]++;
                else dict.Add(a, 1);
            }

            for(int i = 0; i<dict.Count; i++)
            {
                var d = dict.ElementAt(i);
                if(d.Value == 0)
                    continue;

                int want = d.Key < 0 ? d.Key / 2 : d.Key * 2;
                if (d.Key < 0 && d.Key % 2 != 0 || !dict.TryGetValue(want, out int wantValue) || d.Value > wantValue)
                    return false;

                dict[want] -= d.Value;
            }

            return true;
        }
    }
}
