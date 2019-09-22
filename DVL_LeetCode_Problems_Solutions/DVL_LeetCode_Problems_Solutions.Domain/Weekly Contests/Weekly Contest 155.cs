﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial  class ProblemSolver
    {
        /// <summary>
        /// Minimum Absolute Difference (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            var list = new List<IList<int>>();
            Array.Sort(arr);
            int minDiff = int.MaxValue;
            for (int i = 1; i < arr.Length; i++)
            {
                int k = arr[i] - arr[i - 1];
                if (k < minDiff)
                    minDiff = k;
            }

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] - arr[i - 1] == minDiff)
                    list.Add(new List<int>() {arr[i - 1], arr[i]});

            return list;
        }

        public static int NthUglyNumber(int n, int a, int b, int c)
        {
            var list = new List<int>(){a,b,c};
            list.Sort();

            int div1 = list[1] / list[0];
            for (int i = 2; i < div1; i++)
                list.Add(list[0] * i);

            int div2 = list[2] / list[0];
            for (int i = div1; i < div2; i++)
                list.Add(list[0] * i);

            int div3 = list[2] / list[1];
            for (int i = 2; i < div3; i++)
                list.Add(list[1] * i);

            var uglyNumbers = list.Distinct().OrderBy(i => i).ToList();

            return (n / uglyNumbers.Count + 1) * uglyNumbers[n % uglyNumbers.Count - 1 > 0 ? n % uglyNumbers.Count - 1 : uglyNumbers.Count - 1];
        }

        public static string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
        {
            var dic = new Dictionary<int, HashSet<int>>();
            foreach (var pair in pairs)
            {
                if(dic.ContainsKey(pair[0]))
                    dic[pair[0]].Add(pair[1]);
                else dic.Add(pair[0], new HashSet<int>(){pair[1]});
                if (dic.ContainsKey(pair[1]))
                    dic[pair[1]].Add(pair[0]);
                else dic.Add(pair[1], new HashSet<int>() { pair[0] });
            }

            var viewedSet = new HashSet<int>();
            var sets = new List<HashSet<int>>();
            foreach (var keyValue in dic)
            {
                if (!viewedSet.Contains(keyValue.Key))
                {
                   var set = new HashSet<int>(keyValue.Value);
                   set.Add(keyValue.Key);
                   foreach (var keyValue2 in keyValue.Value)
                   {
                       
                   }
                }
            }
        }
    }
}
