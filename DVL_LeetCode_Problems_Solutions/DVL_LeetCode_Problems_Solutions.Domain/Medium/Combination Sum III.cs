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
            var stack = new Stack<int>();
            var arr = Enumerable.Range(1, 9).ToArray();
            Dfs();
            
            return result;

            void Dfs(int index = 0, int currSum = 0)
            {
                if (stack.Count == k)
                {
                    if (currSum == n)
                        result.Add(stack.ToList());
                    return;
                }

                if (currSum >= n)
                    return;

                for (int i = index; i < arr.Length; i++)
                {
                    stack.Push(arr[i]);
                    Dfs(i + 1, currSum + arr[i]);
                    stack.Pop();
                }
            }
        }
    }
}