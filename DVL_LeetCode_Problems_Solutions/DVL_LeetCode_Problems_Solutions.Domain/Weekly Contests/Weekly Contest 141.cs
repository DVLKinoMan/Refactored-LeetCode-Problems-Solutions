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
        /// Shortest Path in Binary Matrix (Not Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int ShortestPathBinaryMatrix(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;

            if (grid[m - 1][n - 1] == 1 || grid[0][0] == 1)
                return -1;

            var dir = new (int, int)[] {(0, 1), (0, -1), (1, 0), (-1, 0), (1, -1), (-1, 1), (-1, -1), (1, 1)};
            bool[,] visited = new bool[grid.Length, grid[0].Length];
            var coordinates = new Queue<(int, int)>();
            coordinates.Enqueue((0, 0));
            visited[0, 0] = true;

            int count = 0;
            while (coordinates.Count > 0)
            {
                int size = coordinates.Count;
                for (int i = 0; i < size; i++)
                {
                    var coo = coordinates.Dequeue();

                    if (coo.Item1 == m - 1 && coo.Item2 == n - 1)
                        return count + 1;

                    for (int d = 0; d < dir.Length; d++)
                    {
                        int nextX = coo.Item1 + dir[d].Item1;
                        int nextY = coo.Item2 + dir[d].Item2;

                        if (nextX >= 0 && nextX < m && nextY >= 0 && nextY < n && !visited[nextX, nextY] &&
                            grid[nextX][nextY] == 0)
                        {
                            coordinates.Enqueue((nextX, nextY));
                            visited[nextX, nextY] = true;
                        }
                    }
                }

                count++;
            }

            return -1;
        }

        /// <summary>
        /// Shortest Common Supersequence (Not Mine)
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string ShortestCommonSupersequence(string str1, string str2)
        {
            string[,] m = new string[str1.Length + 1, str2.Length + 1];
            for (int i = 0; i <= str1.Length; i++)
                m[i, 0] = "";
            for (int j = 0; j <= str2.Length; j++)
                m[0, j] = "";

            for (int i = 0; i < str1.Length; i++)
            for (int j = 0; j < str2.Length; j++)
                if (str1[i] == str2[j])
                    m[i + 1, j + 1] = m[i, j] + str1[i];
                else
                    m[i + 1, j + 1] = m[i + 1, j].Length > m[i, j + 1].Length ? m[i + 1, j] : m[i, j + 1];

            int i1 = 0, j1 = 0;
            string lcs = m[str1.Length, str2.Length];
            string result = string.Empty;
            foreach (var c in lcs)
            {
                while (i1 < str1.Length && str1[i1] != c)
                    result += str1[i1++];
                while (j1 < str2.Length && str2[j1] != c)
                    result += str2[j1++];
                result += c;
                i1++;
                j1++;
            }

            return result + str1.Substring(i1) + str2.Substring(j1);
        }
    }
}
