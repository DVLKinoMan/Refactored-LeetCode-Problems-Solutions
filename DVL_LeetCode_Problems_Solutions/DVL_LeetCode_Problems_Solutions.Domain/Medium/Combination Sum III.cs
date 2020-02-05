using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Combination Sum III (Mine)
        /// </summary>
        /// <param name="k"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            var result = new List<IList<int>>();
            var visitedSet = new HashSet<int>();
            var arr = Enumerable.Range(1, 9).ToArray();
            Dfs();
            
            return result;

            void Dfs(int index = 0, int currSum = 0)
            {
                if (visitedSet.Count == k)
                {
                    if (currSum == n)
                        result.Add(visitedSet.ToList());
                    return;
                }

                if (currSum >= n)
                    return;

                for (int i = index; i < arr.Length; i++)
                    if (!visitedSet.Contains(arr[i]))
                    {
                        visitedSet.Add(arr[i]);
                        Dfs(i + 1, currSum + arr[i]);
                        visitedSet.Remove(arr[i]);
                    }
            }
        }
    }
}