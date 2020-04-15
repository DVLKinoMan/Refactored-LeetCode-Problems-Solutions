using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Queries on a Permutation With Key (Not Mine)
        /// </summary>
        /// <param name="queries"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int[] ProcessQueries(int[] queries, int m)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            int[] result = new int[queries.Length];

            for (int i = 1; i <= m; i++)
                numbers.AddLast(i);

            for (int i = 0; i < queries.Length; i++)
            {
                int q = queries[i];
                var head = numbers.First;
                int index = 0;

                while (head != numbers.Last && head.Value != q)
                {
                    index++;
                    head = head.Next;
                }

                result[i] = index;

                numbers.Remove(head); // O(1)
                numbers.AddFirst(q);
            }

            return result;
        }
    }
}