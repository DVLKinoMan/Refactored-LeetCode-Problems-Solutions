using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Remove to Make Valid Parentheses (Not woktfing
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string MinRemoveToMakeValid(string s)
        {
            var notClosedIntexes = new List<int>();
            var removedIndexes = new List<int>();
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    k++;
                    notClosedIntexes.Add(i);
                }
                else if (s[i] == ')')
                {
                    if (k == 0)
                    {
                        removedIndexes.Add(i);
                        continue;
                    }

                    k--;
                    notClosedIntexes.RemoveAt(notClosedIntexes.Count - 1);
                }
            }

            var union = new HashSet<int>(notClosedIntexes.Union(removedIndexes));
            var str = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
                if (!union.Contains(i))
                    str.Append(s[i]);

            return s.ToString();
        }
    }
}
