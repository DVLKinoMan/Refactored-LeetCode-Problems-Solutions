using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Subtract the Product and Sum of Digits of an Integer (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SubtractProductAndSum(int n)
        {
            var digits = n.ToString().Select(i => int.Parse(i.ToString())).ToArray();
            var product = digits.Aggregate((digit1, digit2) => digit1 * digit2);
            var sum = digits.Sum();
            return product - sum;
        }

        /// <summary>
        /// Group the People Given the Group Size They Belong To (Mine)
        /// </summary>
        /// <param name="groupSizes"></param>
        /// <returns></returns>
        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var dict = new Dictionary<int, List<int>>();
            var res = new List<IList<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (dict.ContainsKey(groupSizes[i]))
                    dict[groupSizes[i]].Add(i);
                else dict.Add(groupSizes[i], new List<int>() {i});
            }

            foreach (var d in dict)
            {
                if(d.Value.Count==d.Key)
                    res.Add(d.Value);
                else
                {
                    int i = 0;
                    while (i < d.Value.Count)
                    {
                        res.Add(d.Value.Skip(i).Take(d.Key).ToList());
                        i += d.Key;
                    }
                }
            }

            return res;
        }

        /// <summary>
        /// Find the Smallest Divisor Given a Threshold (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static int SmallestDivisor(int[] nums, int threshold)
        {
            int left = 1, right = (int)Math.Pow(10,6);
            while (left < right)
            {
                int div = (left + right) / 2, sum = 0;
                foreach (var num in nums)
                    sum += (num + div - 1) / div;
                if (sum > threshold)
                    left = div + 1;
                else
                    right = div;
            }

            return left;
        }
    }
}
