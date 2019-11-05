using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Remove to Make Valid Parentheses (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string MinRemoveToMakeValid(string s)
        {
            var notClosedIndexes = new List<int>();
            var removedIndexes = new List<int>();
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    k++;
                    notClosedIndexes.Add(i);
                }
                else if (s[i] == ')')
                {
                    if (k == 0)
                    {
                        removedIndexes.Add(i);
                        continue;
                    }

                    k--;
                    notClosedIndexes.RemoveAt(notClosedIndexes.Count - 1);
                }
            }

            var union = new HashSet<int>(notClosedIndexes.Union(removedIndexes));
            var str = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
                if (!union.Contains(i))
                    str.Append(s[i]);

            return str.ToString();
        }
    }
}
