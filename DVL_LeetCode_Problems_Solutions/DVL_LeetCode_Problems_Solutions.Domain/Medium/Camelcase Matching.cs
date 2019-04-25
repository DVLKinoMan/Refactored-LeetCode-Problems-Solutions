using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Camel Case Matching
        /// </summary>
        /// <param name="queries"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static IList<bool> CamelMatch(string[] queries, string pattern)
        {
            IList<bool> list=new List<bool>();
            foreach (var q in queries)
            {
                bool answer = true;
                int pi = 0, i = 0;
                while (i < q.Length)
                {
                    if (pi < pattern.Length && q[i] == pattern[pi])
                        pi++;
                    else if (char.IsUpper(q[i]))
                    {
                        answer = false;
                        break;
                    }

                    i++;
                }

                list.Add(answer && pi == pattern.Length);
            }

            return list;
        }
    }
}
