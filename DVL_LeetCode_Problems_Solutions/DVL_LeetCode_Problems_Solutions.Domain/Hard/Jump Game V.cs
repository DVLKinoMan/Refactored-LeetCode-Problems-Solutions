using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Jump Game V (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int MaxJumps(int[] arr, int d) {
            var dict = new Dictionary<int,int>();
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
                result = Math.Max(result, Dfs(i));

            return result + 1;

            int Dfs(int index)
            {
                if (dict.ContainsKey(index))
                    return dict[index];

                int max = 0;
                for (int x = 1; x <= d && index + x < arr.Length && arr[index + x] < arr[index]; x++)
                    max = Math.Max(max, Dfs(index + x) + 1);

                for (int x = 1; x <= d && index - x >= 0 && arr[index - x] < arr[index]; x++)
                    max = Math.Max(max, Dfs(index - x) + 1);

                return dict[index] = max;
            }
        }
    }
}