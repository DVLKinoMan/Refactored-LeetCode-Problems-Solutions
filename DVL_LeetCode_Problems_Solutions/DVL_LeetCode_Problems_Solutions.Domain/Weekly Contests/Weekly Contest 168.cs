using System;
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
            int len = nums.Length;
            if (len % k != 0)
                return false;
            var map = new Dictionary<int,int>();
            Queue<int> pq = new Queue<int>();
            foreach (int n in nums)
                map[n] = map.ContainsKey(n) ? map[n] + 1 : 1;
            foreach (int n in map.Keys)
                pq.Enqueue(n);
            while (pq.Count!=0)
            {
                int cur = pq.Dequeue();
                if (map[cur] == 0)
                    continue;
                int times = map[cur];
                for (int i = 0; i < k; i++)
                {
                    if (!map.ContainsKey(cur + i) || map[cur + i] < times)
                        return false;
                    map[cur + i] -= times;
                }
                len -= k * times;
            }
            return len == 0;
        }
    }
}
