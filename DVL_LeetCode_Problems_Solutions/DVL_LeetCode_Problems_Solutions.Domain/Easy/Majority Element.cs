using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Majority Element (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MajorityElement(int[] nums)
        {
            var dic = new Dictionary<int,int>();
            int n = nums.Length / 2;
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    if (dic[num] > n)
                        return num;
                    dic[num]++;
                }
                else dic.Add(num, 1);
            }

            int maxValue = dic.Max(d => d.Value);
            return dic.FirstOrDefault(d => d.Value == maxValue).Key;
        }
    }
}
