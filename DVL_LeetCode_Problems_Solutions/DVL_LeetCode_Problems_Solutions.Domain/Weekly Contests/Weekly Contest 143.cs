using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Distribute Candies to People (Mine)
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="num_people"></param>
        /// <returns></returns>
        public static int[] DistributeCandies(int candies, int num_people)
        {
            int[] res = new int[num_people];

            int index = 0, currCandy = 1;
            while (candies > 0)
            {
                if (candies - currCandy >= 0)
                    res[index] += currCandy;
                else
                {
                    res[index] += candies;
                    break;
                }

                candies -= currCandy;
                index = (index + 1) % num_people;
                currCandy++;
            }

            return res;
        }

        /// <summary>
        /// Distribute Candies to People (Not Mine)
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="num_people"></param>
        /// <returns></returns>
        public static int[] DistributeCandies2(int candies, int num_people)
        {
            int[] res = new int[num_people];
            for (int i = 0; candies > 0; ++i)
            {
                res[i % num_people] += Math.Min(candies, i + 1);
                candies -= i + 1;
            }
            return res;
        }

        /// <summary>
        /// Path In Zigzag Labelled Binary Tree (Mine)
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public static IList<int> PathInZigZagTree(int label)
        {
            var list = new List<int>();
            int row = (int)Math.Floor(Math.Log(label, 2));

            list.Add(label);
            int curr = label;
            while (row != 0)
            {
                int num = (int) Math.Pow(2, row);
                int parentPos = (int)Math.Ceiling((curr - num + 1) / (double)2);
                curr = num - parentPos;
                list.Add(curr);
                row--;
            }

            list.Reverse();
            return list;
        }
    }
}
