using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Duplicate Zeros (Mine)
        /// </summary>
        /// <param name="arr"></param>
        public static void DuplicateZeros(int[] arr)
        {
            if (arr.Length == 0)
                return;

            int[] arr2 = new int[arr.Length];
            int i = 0, i2 = 0;
            while (i2 < arr.Length)
            {
                if (arr[i] != 0)
                    arr2[i2] = arr[i];
                else i2++;

                i2++;
                i++;
            }

            for (int index = 0; index < arr2.Length; index++)
                arr[index] = arr2[index];
        }

        /// <summary>
        /// Largest Values From Labels (Mine)
        /// </summary>
        /// <param name="values"></param>
        /// <param name="labels"></param>
        /// <param name="num_wanted"></param>
        /// <param name="use_limit"></param>
        /// <returns></returns>
        public static int LargestValsFromLabels(int[] values, int[] labels, int num_wanted, int use_limit)
        {
            int result = 0;
            var dic = new Dictionary<int,List<int>>();
            for (int i = 0; i < values.Length; i++)
            {
                if (dic.ContainsKey(values[i]))
                    dic[values[i]].Add(labels[i]);
                else dic.Add(values[i], new List<int>() {labels[i]});
            }

            int count = 0;
            var usedLabels = new Dictionary<int, int>();
            foreach (var pair in dic.OrderByDescending(d=>d.Key))
            {
                foreach (var val in pair.Value)
                {
                    if (usedLabels.ContainsKey(val) && usedLabels[val] == use_limit)
                        continue;

                    result += pair.Key;

                    if (usedLabels.ContainsKey(val))
                        usedLabels[val]++;
                    else usedLabels.Add(val, 1);

                    count++;

                    if (count == num_wanted)
                        return result;
                }
            }

            return result;
        }

        /// <summary>
        /// Not working
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int ShortestPathBinaryMatrix(int[][] grid)
        {
            int res = ShortestPathBinaryMatrixHelper(grid, 0, 0);
            return res;
        }

        private static int ShortestPathBinaryMatrixHelper(int[][] grid, int i, int j)
        {
            if (i >= grid.Length)
                return -1;
            if (j >= grid[0].Length)
                return -1;
            if (grid[i][j] == 1)
                return -1;
            if (grid.Length - 1 == i && grid[0].Length - 1 == j)
                return 1;

            int f = ShortestPathBinaryMatrixHelper(grid, i + 1, j) + 1;
            int s = ShortestPathBinaryMatrixHelper(grid, i, j + 1) + 1;
            int t = ShortestPathBinaryMatrixHelper(grid, i + 1, j + 1) + 1;

            int res = Math.Min(Math.Min(f == 0 ? int.MaxValue : f, s == 0 ? int.MaxValue : s), t == 0 ? int.MaxValue : t);

            return res == int.MaxValue ? -1 : res;
        }

        //public string ShortestCommonSupersequence(string str1, string str2)
        //{
        //    int[,] m = new int[str1.Length + 1, str2.Length + 1];

        //    int maxSubstrLen = 0;
        //    (int, int) maxSubstrCoo = (-1, -1);
        //    for (int i = 0; i < str1.Length; i++)
        //    for (int j = 0; j < str2.Length; j++)
        //        if (str1[i] == str2[j])
        //        {
        //            m[i + 1, j + 1] += m[i, j];
        //            if (m[i + 1, j + 1] > maxSubstrLen)
        //            {
        //                maxSubstrLen = m[i + 1, j + 1];
        //                maxSubstrCoo = (i, j);
        //            }
        //        }

        //}
    }
}
