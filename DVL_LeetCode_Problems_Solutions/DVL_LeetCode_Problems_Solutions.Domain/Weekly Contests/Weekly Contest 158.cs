using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Split a String in Balanced Strings (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int BalancedStringSplit(string s)
        {
            int count = 0, res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'R')
                    count++;
                else if (s[i] == 'L')
                    count--;
                if (count == 0)
                    res++;
            }

            return res;
        }

        /// <summary>
        /// Queens That Can Attack the King (Mine)
        /// </summary>
        /// <param name="queens"></param>
        /// <param name="king"></param>
        /// <returns></returns>
        public static IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king)
        {
            var res = new List<IList<int>>();
            var vectors = new (int i, int j)[] {(1, 0), (0, 1), (-1, 0), (0, -1), (-1, -1), (1, 1), (-1, 1), (1, -1)};
            foreach (var vec in vectors)
            {
                (int i, int j) currPos = (king[0] + vec.i, king[1] + vec.j);
                while (currPos.i < 8 && currPos.j < 8 && currPos.i >= 0 && currPos.j >= 0)
                {
                    var q = queens.FirstOrDefault(arr => arr[0] == currPos.i && arr[1] == currPos.j);
                    if (q != null)
                    {
                        res.Add(q);
                        break;
                    }
                    currPos = (currPos.i + vec.i, currPos.j + vec.j);
                }
            }

            return res;
        }

        /// <summary>
        /// Maximum Equal Frequency (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxEqualFreq(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            var dicSets = new Dictionary<int, HashSet<int>>();
            int maxLength = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]]++;
                    dicSets[dic[nums[i]] - 1].Remove(nums[i]);
                    if (dicSets[dic[nums[i]] - 1].Count == 0)
                        dicSets.Remove(dic[nums[i]] - 1);
                    if (dicSets.ContainsKey(dic[nums[i]]))
                        dicSets[dic[nums[i]]].Add(nums[i]);
                    else dicSets.Add(dic[nums[i]], new HashSet<int>() {nums[i]});
                }
                else
                {
                    dic.Add(nums[i], 1);
                    if (dicSets.ContainsKey(1))
                        dicSets[1].Add(nums[i]);
                    else dicSets.Add(1, new HashSet<int>() {nums[i]});
                }

                if (IsValid())
                    maxLength = Math.Max(maxLength, i + 1);
            }

            return maxLength;

            bool IsValid()
            {
                if (dicSets.Count != 2)
                {
                    if (dicSets.Count == 1 && (dicSets.First().Key == 1 || dicSets.First().Value.Count == 1))
                        return true;

                    return false;
                }

                var first = dicSets.First();
                var sec = dicSets.Skip(1).Take(1).First();

                return (first.Key == 1 && first.Value.Count == 1) ||
                       (sec.Key == 1 && sec.Value.Count == 1) ||
                       (first.Value.Count == 1 && first.Key - 1 == sec.Key) ||
                       (sec.Value.Count == 1 && sec.Key - 1 == first.Key);
            }
        }
    }
}
