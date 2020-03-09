using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Lexicographical Numbers (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<int> LexicalOrder(int n)
        {
            return Enumerable.Range(1, n)
                .Select(r => r.ToString())
                .OrderBy(r => r)
                .Select(int.Parse)
                .ToList();
        }
        
        /// <summary>
        ///  Lexicographical Numbers (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<int> LexicalOrderBetter(int n)
        {
            var list = new List<int>();
            for (int i = 1; i < 10; i++)
                Dfs(i);

            return list;
            
            void Dfs(int cur)
            {
                if (cur > n)
                    return;
                list.Add(cur);
                for (int i = 0; i < 10; i++)
                {
                    if (10 * cur + i > n)
                        return;
                    Dfs(10*cur + i);
                }
            }
        }
    }
}