using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// The K Weakest Rows in a Matrix (Mine)
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < mat.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] != 1)
                        break;
                    count++;
                }
                dict.Add(i, count);
            }

            return dict.OrderBy(d => d.Value)
                .ThenBy(d => d.Key)
                .Take(k)
                .Select(d => d.Key)
                .ToArray();
        }

        /// <summary>
        /// Reduce Array Size to The Half (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int MinSetSize(int[] arr)
        {
            int n = arr.Length / 2;
            var dict = new Dictionary<int, int>();
            foreach (var num in arr)
                dict[num] = dict.ContainsKey(num) ? dict[num] + 1 : 1;

            int setLen = 0, count = 0;
            foreach (var pair in  dict.OrderByDescending(d=>d.Value))
            {
                count += pair.Value;
                setLen++;
                if (count >= n)
                    return setLen;
            }

            return setLen;
        }
    }
}
