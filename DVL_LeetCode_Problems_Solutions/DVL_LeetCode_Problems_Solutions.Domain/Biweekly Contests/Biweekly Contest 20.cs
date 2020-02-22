using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sort Integers by The Number of 1 Bits (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] SortByBits(int[] arr)
        {
            return arr.OrderBy(num => System.Convert.ToString(num, 2)
                    .Count(ch => ch == '1'))
                .ThenBy(num => num)
                .ToArray();
        }

        /// <summary>
        /// Number of Substrings Containing All Three Characters (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int NumberOfSubstrings(string s)
        {
            HashSet<char> set = new HashSet<char>();
            var dict = new Dictionary<char, int>()
            {
                {'a', 0},
                {'b', 0},
                {'c', 0}
            };
            int count = 0, j = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i - 1 >= 0)
                {
                    dict[s[i - 1]]--;
                    if (dict[s[i - 1]] == 0)
                        set.Remove(s[i - 1]);
                    else
                    {
                        count += s.Length - j;
                        continue;
                    }
                }

                if (i == 0)
                    dict[s[i]]++;
                set.Add(s[i]);
                for (++j; j < s.Length; j++)
                {
                    set.Add(s[j]);
                    dict[s[j]]++;
                    if (set.Count == 3)
                    {
                        count += s.Length - j;
                        break;
                    }
                }

                if (j == s.Length)
                    break;
            }

            return count;
        }
    }
}