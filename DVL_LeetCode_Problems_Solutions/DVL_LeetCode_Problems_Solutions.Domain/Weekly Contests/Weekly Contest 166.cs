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

        public static int SmallestDivisor(int[] nums, int threshold)
        {
            int sum = nums.Sum();
            int div = sum / threshold;
            if (div == 0)
                div = 1;
            int ans = Func(div);
            while (ans>threshold)
            {
                div++;
                ans = Func(div);
            }

            return div;

            int Func(int d)
            {
                int res = 0;
                foreach (var num in nums)
                    res += num / d + (num % d > 0 ? 1 : 0);
                return res;
            }
        }
    }
}
