using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Numbers with Even Number of Digits (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindNumbers(int[] nums)
        {
            int count = 0;
            foreach (var num in nums)
                if (Contains(num))
                    count++;

            return count;

            bool Contains(int n)
            {
                return n.ToString().Length % 2 == 0;
            }
        }

        /// <summary>
        /// Divide Array in Sets of K Consecutive Numbers (Not Working)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool IsPossibleDivide(int[] nums, int k)
        {
            if (nums.Length % k != 0)
                return false;

            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
                dict[num] = dict.ContainsKey(num) ? dict[num] + 1 : 1;

            var newDict = new Dictionary<int,int>();

            foreach (var keyValue in dict.OrderBy(d => d.Key))
                newDict.Add(keyValue.Key, keyValue.Value);

            dict = newDict;

            while (dict.Count != 0)
            {
                var f = dict.First();
                if (f.Value == 0)
                {
                    dict.Remove(f.Key);
                    continue;
                }

                int c = 1;
                int key = f.Key;
                dict[f.Key]--;
                while (c != k)
                {
                    if (!dict.ContainsKey(key + 1) || dict[key + 1] == 0)
                        return false;
                    dict[key + 1]--;
                    key++;
                    c++;
                }
            }

            return true;
        }
    }
}
