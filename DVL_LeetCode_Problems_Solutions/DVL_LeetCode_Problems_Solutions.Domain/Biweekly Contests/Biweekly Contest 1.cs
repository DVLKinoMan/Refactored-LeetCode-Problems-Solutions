using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Fixed Point(Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int FixedPoint(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
                if (A[i] == i)
                    return i;
            return -1;
        }

        /// <summary>
        /// Index Pairs of a String (Mine)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static int[][] IndexPairs(string text, string[] words)
        {
            var list = new List<(int, int)>();
            foreach (var word in words)
            {
                for (int i = 0; i <= text.Length - word.Length; i++)
                    if (text.Substring(i, word.Length) == word)
                        list.Add((i, i + word.Length - 1));
            }

            list = list.OrderBy(l => l.Item1).ThenBy(l => l.Item2).ToList();

            var arr = new int[list.Count][];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new int[] { list[i].Item1, list[i].Item2 };

            return arr;
        }

        /// <summary>
        /// Not works (Time Limit)
        /// </summary>
        /// <param name="workers"></param>
        /// <param name="bikes"></param>
        /// <returns></returns>
        public static int AssignBikes(int[][] workers, int[][] bikes)
        {
            return AssignBikesHelper(workers, bikes, new List<int>(), new List<int>());
        }

        private static int AssignBikesHelper(int[][] workers, int[][] bikes, List<int> workersOutIndexes,
            List<int> bikesOutIndexes)
        {
            if (workersOutIndexes.Count == workers.Length)
                return 0;

            int result = int.MaxValue;
            for (int i = 0; i < workers.Length; i++)
                if (!workersOutIndexes.Contains(i))
                {
                    workersOutIndexes.Add(i);
                    for (int j = 0; j < bikes.Length; j++)
                        if (!bikesOutIndexes.Contains(j))
                        {
                            int dist = Math.Abs(workers[i][0] - bikes[j][0]) + Math.Abs(workers[i][1] - bikes[j][1]);
                            bikesOutIndexes.Add(j);
                            result = Math.Min(result,
                                dist + AssignBikesHelper(workers, bikes, workersOutIndexes, bikesOutIndexes));
                            bikesOutIndexes.RemoveAt(bikesOutIndexes.Count - 1);
                        }

                    workersOutIndexes.RemoveAt(workersOutIndexes.Count - 1);
                }

            return result;
        }
    }
}
