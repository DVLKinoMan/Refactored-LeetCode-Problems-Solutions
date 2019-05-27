using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Weekly_Contests
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Height Checker (Mine)
        /// </summary>
        /// <param name="heights"></param>
        /// <returns></returns>
        public static int HeightChecker(int[] heights)
        {
            int count = 0;
            int[] sorted = heights.ToArray();
            Array.Sort(sorted);

            for (int i = 0; i < heights.Length; i++)
                if (sorted[i] != heights[i])
                    count++;

            return count;
        }

        /// <summary>
        /// Grumpy Bookstore Owner (Mine)
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="grumpy"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public static int MaxSatisfied(int[] customers, int[] grumpy, int X)
        {
            int maxStraightX = customers.Take(X).Where((c, i) => grumpy[i] == 1).Sum();
            int currStraightX = maxStraightX;
            for (int i = X; i < customers.Length; i++)
            {
                currStraightX = currStraightX - (grumpy[i - X] == 1 ? customers[i - X] : 0) +
                                (grumpy[i] == 1 ? customers[i] : 0);
                if (currStraightX > maxStraightX)
                    maxStraightX = currStraightX;
            }

            int res = customers.Where((c, i) => grumpy[i] != 1).Sum() + maxStraightX;
            return res;
        }

        /// <summary>
        /// Previous Permutation With One Swap (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] PrevPermOpt1(int[] A)
        {
            for (int i = A.Length - 2; i >= 0; i--)
            {
                int lessMax = -1, lessMaxJ = -1;
                for (int j = i + 1; j < A.Length; j++)
                    if (A[j] < A[i] && A[j] >= lessMax)
                    {
                        lessMax = A[j];
                        lessMaxJ = j;
                    }

                if (lessMaxJ != -1)
                {
                    int k = A[i];
                    A[i] = A[lessMaxJ];
                    A[lessMaxJ] = k;
                    return A;
                }
            }

            return A;
        }

        /// <summary>
        /// Distant Barcodes (Not Mine)
        /// </summary>
        /// <param name="barcodes"></param>
        /// <returns></returns>
        public static int[] RearrangeBarcodes(int[] barcodes)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < barcodes.Length; i++)
            {
                if (dic.ContainsKey(barcodes[i]))
                    dic[barcodes[i]]++;
                else dic.Add(barcodes[i], 1);
            }

            int index = 0;
            foreach (var pair in dic.OrderByDescending(d => d.Value))
                for (int i = 0; i < pair.Value; i++)
                {
                    if (index >= barcodes.Length)
                        index = 1;

                    barcodes[index] = pair.Key;
                    index += 2;
                }

            return barcodes;
        }
    }
}
