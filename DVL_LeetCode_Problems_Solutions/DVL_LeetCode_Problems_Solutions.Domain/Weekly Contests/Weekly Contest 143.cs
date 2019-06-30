using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static IList<int> PathInZigZagTree(int label)
        {
            var list = new List<int>();

            int row = (int)Math.Floor(Math.Log(label, 2));

            list.Add(label);
            int curr = label;
            while (row != 0)
            {
                int parentPos = (curr - (int)Math.Pow(2, row) + 1) % (int)Math.Pow(2, row - 1);
                int num = (int)Math.Pow(2, row - 1);
                curr = num + (row % 2 == 0 ? parentPos : (num - (parentPos + 1)));
                list.Add(curr);
                row--;
            }

            list.Reverse();
            return list;
        }
    }
}
